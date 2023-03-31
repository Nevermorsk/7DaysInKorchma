using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Audio;
using UnityEngine.UI;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;

public class DialogueSystem : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textField;
    [SerializeField] private TextMeshProUGUI nameField;

    [SerializeField] float TextSpeed;

    [SerializeField] private GameObject SceneSwitcher;
    [SerializeField] private GameObject Dialogue;

    [SerializeField] private GameObject AcceptBtn;
    [SerializeField] private GameObject DeclineBtn;

    private AudioSource audioSource;
    [HideInInspector] public static Replica currentDialog;

    private int choiceNum = 0;
    private bool skipDial = false;
    private bool isChoice = false;
    private bool lastDayAddMoney = true;
    private void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        AudioMixer audioMixer = Resources.Load<AudioMixer>("audio/mixer/main");
        AudioMixerGroup[] audioMixGroup = audioMixer.FindMatchingGroups("Master");
        audioSource.outputAudioMixerGroup = audioMixGroup[3];

        StartCoroutine(Start());
        IEnumerator Start()
        {
            while (DontDestroy.dayDialogue.IsUnityNull()) yield return null;
            if (OrderSystem.timerDone) {
                Debug.Log("Timer done");
                if (OrderSystem.fatalEnd != 0)
                {
                    switch (OrderSystem.fatalEnd)
                    {
                        case 1:
                            Debug.Log("fatalend 1 если не обслужил звездочета");
                            transitionScipt.LoadScene("MainMenu", "bad2");
                            break;                        
                        case 2:
                            Debug.Log("fatalend 2 псих взорвал нахуй если не обслужил");
                            transitionScipt.LoadScene("MainMenu", "boom");
                            break;                        
                    }
                }
                OrderSystem.timerDone = false;
                if (DontDestroy.Day != 7) {
                    DontDestroy.dayDialogue.Dequeue();
                    currentDialog = new Replica()
                    {
                        text = "Похоже клиент остался недоволен...",
                        author = "Вы",
                        sprite = "empty",
                        audio = "gg/gg_neydov"
                    };
                } else {
                    lastDayAddMoney = false;
                    currentDialog = DontDestroy.dayDialogue.Dequeue(); 
                }
            } else { currentDialog = DontDestroy.dayDialogue.Dequeue(); }

            StartCoroutine(TypeLine()); // старт диалога
        }
    }

    private void Update()
    {

        if (Input.GetMouseButtonDown(0) && !pauseScript.isPaused
            && !GameObject.FindGameObjectWithTag("trading").transform.GetChild(0).gameObject.active
            && !GameObject.FindGameObjectWithTag("frogtrading").transform.GetChild(0).gameObject.active
            && Dialogue.active && !isChoice)
        {
            if (textField.text == currentDialog.text)
            {
                IsNextLine();
            }
            else
            {
                skipDial = true;
            }
        }
    }

    IEnumerator TypeLine()
    {
        GameObject.FindWithTag("Speaker").GetComponent<Image>().sprite = Resources.Load<Sprite>($"Characters/{currentDialog.sprite}");
        if (DontDestroy.Diffuculty != 1 && currentDialog.author == "Невидимый человек") { currentDialog.text = "***Неразборчивая речь летающей шляпы***"; }
        nameField.text = currentDialog.author;

        if (currentDialog.audio != null)
        {
            audioSource.playOnAwake = false;
            audioSource.Stop();
            audioSource.clip = Resources.Load($"audio/dialogue/{currentDialog.audio}") as AudioClip;
            audioSource.Play();
        }

        foreach (char c in currentDialog.text.ToCharArray())
        {
            if (skipDial)
            {
                textField.text = currentDialog.text;
                skipDial = false;
                break;
            }
            textField.text += c;
            yield return new WaitForSeconds(TextSpeed);
        }

        // хуйня с выдачей денег
        if (currentDialog.moneyChange != 0)
        {
            DontDestroy.moneyChange(currentDialog.moneyChange);
        }
        if (currentDialog.action != null)
        {
            StartCurrentAction();
        }


    }

    private void IsNextLine()
    {
        if (currentDialog.order == null)
        {
            currentDialog = DontDestroy.dayDialogue.Dequeue();
            textField.text = string.Empty;
            StartCoroutine(TypeLine());
        } else
        {
            OrderSystem.receipt = currentDialog.order;
            OrderSystem.fatalEnd = currentDialog.fatalEnd;
            ColorCheck.vineNeed = currentDialog.needVine;
            Dialogue.SetActive(false);
            SceneSwitcher.SetActive(true);
        }
        
    }

    public void StartCurrentAction()
    {
        switch (currentDialog.action)
        {
            case "trading":
                GameObject.FindGameObjectWithTag("trading").transform.GetChild(0).gameObject.SetActive(true);
                break;   
                
            case "frogtrading":
                GameObject.FindGameObjectWithTag("frogtrading").transform.GetChild(0).gameObject.SetActive(true);
                StartCoroutine(waitClose());

                IEnumerator waitClose() { 
                    yield return new WaitWhile(() => GameObject.FindGameObjectWithTag("frogtrading").transform.GetChild(0).gameObject.active);
                    if (DontDestroy.Day == 5)
                    {
                        if (frogBuyingScript.buyed)
                        {
                            currentDialog = new Replica()
                            {
                                text = "Ну уговор есть уговор. Скинули меня в эту яму без дна, лечу себе день два, и понимаю, что лечу я только по той причине, что думаю о падении в это яме. И ставлю себе целью думать только о подъёме. Ну и спустя пару дней вылетаю обратно. Это я только сейчас понимаю, что надо было думать о возвращении домой, но что есть, то есть",
                                author = "Вы",
                                sprite = "zhaba",
                                audio = "zhaba/zhaba6"
                            };
                        }
                        else
                        {
                            currentDialog = new Replica()
                            {
                                text = "Ну уговор есть уговор, бывай, плебей монархизма",
                                author = "Вы",
                                sprite = "zhaba",
                                audio = "zhaba/zhaba5"
                            };
                        }
                        textField.text = "";
                        StartCoroutine(TypeLine());
                    }

                }

                break;

            case "nextDay":
                Debug.Log($"current day {DontDestroy.Day}");
                DontDestroy.Day += 1;
                Debug.Log($"next day {DontDestroy.Day}");
                StartCoroutine(timer());
                IEnumerator timer()
                {
                    yield return new WaitForSeconds(0.5f);
                    transitionScipt.LoadScene($"Window 1", DontDestroy.Day);
                }
                Debug.Log($"day {DontDestroy.Day}");
                break;

            case "choice1":
                choiceNum = 1;
                isChoice = true;
                AcceptBtn.SetActive(true);
                AcceptBtn.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>().text = "Помочь старцу";
                DeclineBtn.SetActive(true);
                DeclineBtn.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>().text = "Не обслуживать";
                break;            
            case "choice2":
                choiceNum = 2;
                isChoice = true;
                AcceptBtn.SetActive(true);
                AcceptBtn.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>().text = "Начать готовить";
                DeclineBtn.SetActive(true);
                DeclineBtn.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>().text = "Переспросить";
                break;            
            case "choice3":
                choiceNum = 3;
                isChoice = true;
                AcceptBtn.SetActive(true);
                AcceptBtn.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>().text = "Согласиться";
                DeclineBtn.SetActive(true);
                DeclineBtn.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>().text = "Отказаться";
                break;            
            case "choice4":
                choiceNum = 4;
                isChoice = true;
                AcceptBtn.SetActive(true);
                AcceptBtn.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>().text = "Обмануть";
                DeclineBtn.SetActive(true);
                DeclineBtn.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>().text = "Не обманывать";
                break;

            case "zeroMoney":
                DontDestroy.Money = 0;
                break;

            case "lastDayCounter":
                if (lastDayAddMoney)
                {
                    DontDestroy.moneyChange(1);
                }
                else
                {
                    lastDayAddMoney = true;
                }
                break;
                
            case "invDecline":
                currentDialog = new Replica()
                {
                    text = DontDestroy.Diffuculty != 1 ? "Да п...и вы...": "Да пошли вы",
                    author = "Невидимый человек ",
                    sprite = "nosee",
                    audio = "nosee/nosee3"
                };
                textField.text = "";
                StartCoroutine(TypeLine());
                DontDestroy.dayDialogue.Dequeue();
                break;
 
            case "mooseDecline":
                currentDialog = new Replica()
                {
                    text = "Я крайне благодарен вашей Корчме за столь теплый прием… Хотя конечно жаль, что у вас не оказалось соли..",
                    author = "Лось",
                    sprite = "moose",
                    audio = "moose/moose6",
                    moneyChange = 40
                };
                textField.text = "";
                StartCoroutine(TypeLine());
                break;

            case "end":
                if (DontDestroy.Money >= 10)
                {
                    transitionScipt.LoadScene("MainMenu", "Good"); // Хорошая концовка fatalend 6
                }
                {
                    choiceNum = 5;
                    isChoice = true;
                    AcceptBtn.SetActive(true);
                    AcceptBtn.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>().text = "Принять судьбу";
                    DeclineBtn.SetActive(true);
                    DeclineBtn.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>().text = "Сбежать";
                }
                break;

            case "end3":
                transitionScipt.LoadScene("MainMenu", "bad1");
                break;      
                
            case "end4":
                if (DontDestroy.youKilledByInv) {
                    transitionScipt.LoadScene("MainMenu", "Inv");
                } else { 
                    transitionScipt.LoadScene("MainMenu", "Forest"); 
                }
                break;
        }
    }
    public void Accept()
    {
        switch(choiceNum)
        {
            case 1:
                currentDialog = new Replica()
                {   text = "Конечно, бать, держи напиток.",
                    author = "Вы",
                    sprite = "bedouin",
                    audio = "gg/gg10" 
                };
                break;
            case 2:
                currentDialog = new Replica()
                {
                    text = "Хорошо.",
                    author = "Вы",
                    sprite = "nosee",
                    audio = "gg/gg20",
                    order = "sugar"
                };
                break;            
            case 3:
                currentDialog = new Replica()
                {
                    text = "Окей, минутку",
                    author = "Вы",
                    sprite = "bandos",
                    audio = "gg/gg36",
                    order = "",
                    needVine = true
                };
                break;            
            case 4:
                currentDialog = new Replica()
                {
                    text = "Я посмотрю, что у нас есть",
                    author = "Вы",
                    sprite = "moose",
                    audio = "gg/gg37",
                    order = "sugar"
                };
                break;            
            case 5:
                currentDialog = new Replica()
                {
                    text = "Я принимаю свою судьбу...",
                    author = "Вы",
                    sprite = "taxman",
                    action = "end3"
                };
                break;
        }
        AcceptBtn.SetActive(false);
        DeclineBtn.SetActive(false);
        textField.text = "";
        isChoice = false;
        StartCoroutine(TypeLine());
    }
    public void Decline()
    {
        switch (choiceNum)
        {
            case 1:
                currentDialog = new Replica()
                {
                    text = "Прости, бать, никак выручить не могу.",
                    author = "Вы",
                    sprite = "bedouin",
                    audio = "gg/gg9"
                };
                DontDestroy.moneyModifyer = 0.5f;
                break;
            case 2:
                currentDialog = new Replica()
                {
                    text = "Да хватит мямлить, нормально скажи",
                    author = "Вы",
                    sprite = "nosee",
                    audio = "gg/gg8",
                    action = "invDecline"
                };
                DontDestroy.youKilledByInv = true;
                break;            
            case 3:
                currentDialog = new Replica()
                {
                    text = "Извини, ничем не могу помочь",
                    author = "Вы",
                    sprite = "bandos",
                    audio = "gg/gg35",
                };
                DontDestroy.dayDialogue.Dequeue();
                break;            
            case 4:
                currentDialog = new Replica()
                {
                    text = "Извини, ничем не могу помочь",
                    author = "Вы",
                    sprite = "moose",
                    audio = "gg/gg35",
                    action = "mooseDecline"
                };
                DontDestroy.dayDialogue.Dequeue();
                break;
            case 5:
                currentDialog = new Replica()
                {
                    text = "***сбежал в лес***",
                    author = "Вы",
                    sprite = "empty",
                    action = "end4"
                };
                break;
        }
        AcceptBtn.SetActive(false);
        DeclineBtn.SetActive(false);
        textField.text = "";
        isChoice = false;
        StartCoroutine(TypeLine());
    }
}

