using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Linq;

public class DialogueSystem : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;
    private string [] lines = new string[10];
    private string [] authors = new string[10];
    [SerializeField] float TextSpeed;
    [SerializeField] private GameObject SceneSwitcher;
    [SerializeField] private TextMeshProUGUI nameField;
    [SerializeField] private Sprite[] krips;

    private int index;

    private void Start()
    {
        SceneSwitcher.SetActive(false);
        GameObject.FindWithTag("Speaker").GetComponent<SpriteRenderer>().sprite = krips[Random.Range(0, krips.Length)];

        switch (DontDestroy.counter)
        {
            case 0:
                lines[0] = "Здравствуйте, можно блин с сахаром?";
                lines[1] = "Будет сделано.";
                authors[0] = "Заказчик";
                authors[1] = "Вы";
                break;
            case 2:
                lines[0] = "Спасибо, вот деньги.";
                lines[1] = "Всего доброго.";
                authors[0] = "Заказчик";
                authors[1] = "Вы";
                moneyChange(60);
                break;
            case 4:
                lines[0] = "Здравствуйте, блины остались?";
                lines[1] = "Да, конечно остались.";
                authors[0] = "Заказчик";
                authors[1] = "Вы";
                break;
            case 6:
                lines[0] = "Прошу.";
                lines[1] = "Огромное спасибо, досвидание.";
                authors[0] = "Вы";
                authors[1] = "Заказчик";
                moneyChange(60);
                break;
        }

        lines = lines.Where(x => x != null).ToArray();

        text.text = string.Empty;
        nameField.text = authors[index];
        StartDialogue();
    }
    private void moneyChange(int money, bool add = true)
    {
        Debug.Log($"{money} {DontDestroy.money}");
        if (!add && DontDestroy.money >= money)
        {
            DontDestroy.money -= money;
        }
        else if (add)
        {
            DontDestroy.money += money;
            Debug.Log($"{money} {DontDestroy.money}");
        }
        else 
        {
            Debug.Log("Нету денег, лох");
        }
       
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
