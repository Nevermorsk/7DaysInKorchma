using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Audio;
using UnityEngine.UI;

public class DialogueSystem : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textField;
    [SerializeField] private TextMeshProUGUI nameField;

    public static bool definitionHidden = true;
    public static bool canNextDay;

/*    public static List<string> lines = new List<string>();
    public static List<Sprite> authorSprite = new List<Sprite>();
    public static List<string> audios = new List<string>();*/

    [SerializeField] float TextSpeed;

    private static AudioSource addMoney;
    [SerializeField] private GameObject SceneSwitcher;
    [SerializeField] private GameObject Dialogue;

/*    public Sprite[] krips;
    public Sprite[] charachters;*/

    [SerializeField] private GameObject AcceptBtn;
    [SerializeField] private GameObject DeclineBtn;

    private AudioSource audioSource;
    private int index;
    private Replica currentDialog;
    private Queue<Replica> dialogues;

    private void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        AudioMixer audioMixer = Resources.Load<AudioMixer>("audio/mixer/main");
        AudioMixerGroup[] audioMixGroup = audioMixer.FindMatchingGroups("Master");
        audioSource.outputAudioMixerGroup = audioMixGroup[3];

        addMoney = GetComponent<AudioSource>();
        SceneSwitcher.SetActive(false);

        dialogues = Replica.MakeQueue($"dialogues_day{DontDestroy.day}");
        currentDialog = dialogues.Dequeue();
        /*
                lines.Clear();
                authorSprite.Clear();
                audios.Clear();

                Dialogues.DefineDialogue(DontDestroy.day, DontDestroy.counter, krips, charachters);

                text.text = string.Empty;
                nameField.text = lines[index].Split("|")[1];*/

        StartCoroutine(TypeLine()); // старт диалога
    }
    public static void moneyChange(int money, bool add = true)
    {
        Debug.Log($"{money} {DontDestroy.money}");
        if (!add && DontDestroy.money >= money)
        {
            DontDestroy.money -= money;
        }
        else if (add)
        {
            addMoney.Play();
            DontDestroy.money += money;
            Debug.Log($"{money} {DontDestroy.money}");
        }
        else 
        {
            Debug.Log("нет денег");
        }
       
    }
    private void Update()
    {
        if(Input.GetMouseButtonDown(0) && !pauseScript.isPaused)
        {
            if (textField.text == currentDialog.text)
            {
                IsNextLine();
            }
            else
            {
                StopAllCoroutines();
                textField.text = currentDialog.text;
            }
        }
    }

    IEnumerator TypeLine()
    {
        GameObject.FindWithTag("Speaker").GetComponent<Image>().sprite = Resources.Load<Sprite>($"Characters/{currentDialog.sprite}");
        nameField.text = currentDialog.author;

        if (currentDialog.audio != "")
        {
            Debug.Log($"{index} {currentDialog.audio}");
            audioSource.playOnAwake = false;
            audioSource.Stop();
            audioSource.clip = Resources.Load($"audio/dialogue/{currentDialog.audio}") as AudioClip;
            audioSource.Play();
        }

        foreach (char c in currentDialog.text.ToCharArray())
            {
                textField.text += c;
                yield return new WaitForSeconds(TextSpeed);
            }
    }

    private void IsNextLine()
    {
        if (dialogues.Count > 0)
        {
            currentDialog = dialogues.Dequeue();
            textField.text = string.Empty;
            StartCoroutine(TypeLine());
        } else
        {
            Dialogue.SetActive(false);
            SceneSwitcher.SetActive(true);
        }
    }

    public void Hide()
    {
        AcceptBtn.SetActive(false);
        DeclineBtn.SetActive(false);
    }

    public void Show()
    {
        AcceptBtn.SetActive(false);
        DeclineBtn.SetActive(false);
    }
}
