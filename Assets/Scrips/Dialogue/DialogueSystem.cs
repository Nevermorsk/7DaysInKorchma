using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Audio;
using UnityEngine.UI;

public class DialogueSystem : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;
    [SerializeField] private TextMeshProUGUI nameField;

    public static bool definitionHidden = true;
    public static bool canNextDay;

    public static List<string> lines = new List<string>();
    public static List<Sprite> authorSprite = new List<Sprite>();
    public static List<string> audios = new List<string>();

    [SerializeField] float TextSpeed;

    private static AudioSource addMoney;
    [SerializeField] private GameObject SceneSwitcher;
    [SerializeField] private GameObject Dialogue;
    public Sprite[] krips;
    public Sprite[] charachters;
    [SerializeField] private GameObject AcceptBtn;
    [SerializeField] private GameObject DeclineBtn;

    private AudioSource audioSource;
    private int index;

    private void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        AudioMixer audioMixer = Resources.Load<AudioMixer>("audio/mixer/main");
        AudioMixerGroup[] audioMixGroup = audioMixer.FindMatchingGroups("Master");
        audioSource.outputAudioMixerGroup = audioMixGroup[3];

        addMoney = GetComponent<AudioSource>();
        SceneSwitcher.SetActive(false);

        lines.Clear();
        authorSprite.Clear();
        audios.Clear();

        Dialogues.DefineDialogue(DontDestroy.day, DontDestroy.counter, krips, charachters);

        text.text = string.Empty;
        nameField.text = lines[index].Split("|")[1];
        StartDialogue();
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
                if (text.text == lines[index].Split("|")[0])
                {
                    IsNextLine();
                }
            }
    }

    public void StartDialogue()
    {
        index = 0;
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine()
    {
        GameObject.FindWithTag("Speaker").GetComponent<Image>().sprite = authorSprite[index];
        string[] splitted = lines[index].Split("|");
        nameField.text = splitted[1];
        Debug.Log(audios.Count);
        if (audios.Count > 0)
        {
            Debug.Log($"{index} {audios[index]}");
            audioSource.playOnAwake = false;
            audioSource.Stop();
            audioSource.clip = Resources.Load(audios[index]) as AudioClip;
            audioSource.Play();
        }

        foreach (char c in splitted[0].ToCharArray())
            {
                text.text += c;
                yield return new WaitForSeconds(TextSpeed);
            }
    }

    private void IsNextLine()
    {
        if (index < lines.Count - 1)
        {
            index++;
            text.text = string.Empty;
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
