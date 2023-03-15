using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Audio;
using UnityEngine.UI;
using Unity.VisualScripting;

public class DialogueSystem : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textField;
    [SerializeField] private TextMeshProUGUI nameField;

/*    public static List<string> lines = new List<string>();
    public static List<Sprite> authorSprite = new List<Sprite>();
    public static List<string> audios = new List<string>();*/

    [SerializeField] float TextSpeed;

    [SerializeField] private GameObject SceneSwitcher;
    [SerializeField] private GameObject Dialogue;

/*    public Sprite[] krips;
    public Sprite[] charachters;*/

    [SerializeField] private GameObject AcceptBtn;
    [SerializeField] private GameObject DeclineBtn;

    private AudioSource audioSource;
    private Replica currentDialog;
    private bool skipDial = false;
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
            currentDialog = DontDestroy.dayDialogue.Dequeue();
            StartCoroutine(TypeLine()); // старт диалога
        }
    }

    private void Update()
    {
#pragma warning disable CS0618 // Тип или член устарел
        if (Input.GetMouseButtonDown(0) && !pauseScript.isPaused 
            && !GameObject.FindGameObjectWithTag("trading").transform.GetChild(0).gameObject.active
            && Dialogue.active)
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
                DontDestroy.Day += 1;
                transitionScipt.LoadScene($"Window 1", DontDestroy.Day);
                Debug.Log("day 2");
                break;
        }
    }
}
