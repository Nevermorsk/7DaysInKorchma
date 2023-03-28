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
                            transitionScipt.LoadScene("MainMenu", "titles");
                            break;                        
                        case 2:
                            Debug.Log("fatalend 2 псих взорвал нахуй если не обслужил");
                            break;                        
                        case 3:
                            Debug.Log("fatalend 3 за налоги и если не успел в конце и дойстойно принял судьбу");
                            break;                        
                        case 4:
                            Debug.Log("fatalend 4 если не успел в конце и решил съебаться и обслужил невидимку");
                            break;                        
                        case 5:
                            Debug.Log("fatalend 5 если не успел в конце и решил съебаться и НЕ обслужил невидимку");
                            break;                        
                        case 6:
                            Debug.Log("fatalend 6 хорошая концовка");
                            break;
                    }
                }
                OrderSystem.timerDone = false;
                DontDestroy.dayDialogue.Dequeue();
                currentDialog = new Replica()
                {
                    text = "Похоже клиент остался недоволен...",
                    author = "Вы",
                    sprite = "empty",
                    audio = "gg/gg_neydov"
                };

            } else
            {
                currentDialog = DontDestroy.dayDialogue.Dequeue();
            }
            StartCoroutine(TypeLine()); // старт диалога
        }
    }

    private void Update()
    {
#pragma warning disable CS0618 // Тип или член устарел
        if (Input.GetMouseButtonDown(0) && !pauseScript.isPaused
            && !GameObject.FindGameObjectWithTag("trading").transform.GetChild(0).gameObject.active
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
#pragma warning restore CS0618 // Тип или член устарел
    }

    IEnumerator TypeLine()
    {
        GameObject.FindWithTag("Speaker").GetComponent<Image>().sprite = Resources.Load<Sprite>($"Characters/{currentDialog.sprite}");
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

        if (currentDialog.action != null)
        {
            StartCurrentAction();
        }
        if (currentDialog.moneyChange != 0)
        {
            DontDestroy.moneyChange(currentDialog.moneyChange);
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

            case "nextDay":
                Debug.Log($"current day {DontDestroy.Day}");
                DontDestroy.Day += 1;
                Debug.Log($"next day {DontDestroy.Day}");
                transitionScipt.LoadScene($"Window 1", DontDestroy.Day);
                Debug.Log($"day {DontDestroy.Day}");
                break;

            case "choice1":
                choiceNum = 1;
                isChoice = true;
                AcceptBtn.SetActive(true);
                DeclineBtn.SetActive(true);
                break;            
            case "choice2":
                choiceNum = 2;
                isChoice = true;
                AcceptBtn.SetActive(true);
                DeclineBtn.SetActive(true);
                break;            
            case "choice3":
                choiceNum = 3;
                isChoice = true;
                AcceptBtn.SetActive(true);
                DeclineBtn.SetActive(true);
                break;
            case "zeroMoney":
                DontDestroy.Money = 0;
                break;
            case "invDecline":
                currentDialog = new Replica()
                {
                    text = "Да пошли вы",
                    author = "Невидимый человек",
                    sprite = "nosee",
                    audio = "nosee/nosee3"
                };
                textField.text = "";
                StartCoroutine(TypeLine());
                DontDestroy.dayDialogue.Dequeue();
                break;

            case "end":
                transitionScipt.LoadScene("MainMenu", "titles");
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
                    audio = "gg/gg3" 
                };
                break;
            case 2:
                currentDialog = new Replica()
                {
                    text = "Понял, сейчас все будет.",
                    author = "Вы",
                    sprite = "nosee",
                    audio = "gg/gg4",
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
                    audio = "gg/gg3"
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
        }
        AcceptBtn.SetActive(false);
        DeclineBtn.SetActive(false);
        textField.text = "";
        isChoice = false;
        StartCoroutine(TypeLine());
    }
}

