using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueSystem : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;
    [SerializeField] string[] lines;
    [SerializeField] string[] authors;
    [SerializeField] float TextSpeed;
    [SerializeField] private GameObject SceneSwitcher;
    [SerializeField] private TextMeshProUGUI nameField;

    private int index;
    private void Start()
    {
        SceneSwitcher.SetActive(false);
        text.text = string.Empty;
        nameField.text = authors[index];
        StartDialogue();
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if (text.text == lines[index])
            {
                IsNextLine();
            }
            else
            {
                StopAllCoroutines();
                text.text = lines[index];
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
        nameField.text = authors[index];
        foreach (char c in lines[index].ToCharArray())
        {
            text.text += c;
            yield return new WaitForSeconds(TextSpeed);
        }
    }

    private void IsNextLine()
    {
        if (index < lines.Length - 1 )
        {
            index++;
            text.text = string.Empty;
            StartCoroutine(TypeLine());
        } else
        {
            gameObject.SetActive(false);
            SceneSwitcher.SetActive(true);
        }
    }
}
