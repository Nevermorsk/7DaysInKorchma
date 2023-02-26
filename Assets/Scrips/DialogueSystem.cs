using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Linq;
using UnityEngine.SceneManagement;
using System.Timers;

public class DialogueSystem : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;

    private string [] lines = new string[30];
    private Sprite [] authorSprite = new Sprite[30];
    [SerializeField] float TextSpeed;
    [SerializeField] private GameObject SceneSwitcher;
    [SerializeField] private TextMeshProUGUI nameField;
    [SerializeField] private Sprite[] krips;
    [SerializeField] private Sprite[] charachters;

    private int index;

    private void Start()
    {
        SceneSwitcher.SetActive(false);

        GameObject.FindWithTag("Speaker").GetComponent<SpriteRenderer>().sprite = krips[Random.Range(0, krips.Length)];

        switch (DontDestroy.counter)
        {
            case 0:
                lines[0] = "������������, ����� ���� � �������?|��������";
                lines[1] = "����� �������.|��";
                authorSprite[0] = krips[0];
                authorSprite[1] = krips[0];
                break;
            case 2:
                lines[0] = "�������, ��� ������.|��������";
                lines[1] = "����� �������.|��";
                authorSprite[0] = krips[0];
                authorSprite[1] = krips[0];
                GameObject.FindWithTag("DontDestroy").GetComponent<DontDestroy>().money += 60;
                break;
            case 4:
                lines[0] = "������������, ����� ��������?|��������";
                lines[1] = "��, ������� ��������.|��";
                authorSprite[0] = krips[1];
                authorSprite[1] = krips[1];
                break;
            case 6:
                lines[0] = "�����.|��";
                lines[1] = "�������� �������, ����������.|��������";
                authorSprite[0] = krips[1];
                authorSprite[1] = krips[1];
                GameObject.FindWithTag("DontDestroy").GetComponent<DontDestroy>().money += 60;
                break;
            case 8:
                lines[0] = "������������, �� ������ ����� ����������� ���������� ����� ������, �������� �������...|���������";
                lines[1] = "����� �� �� �������, ��� ���������� ������.|��";
                lines[2] = "�� �� ������ �������� ���������� � ����������� ����� ���� ��� ��������� ������|���������";
                lines[3] = "��� ���� ��������, �� ��� �������� ����������� �����, ���� �� ������� ������� � ���������� �����, � �� � ��� ����� �������.|��";
                lines[4] = "� ����� �� ��������, ��� �������� ����������� ��� ������� �������, ������� ������ ���, ���� � ����� �� �� ������������. ��������� �� ��������, ��� ����� �� ����� ���� �����������.|���������";
                lines[5] = "�� ��� ������� ������ ������ � �������� ������� ������� � ������ �������� ���, � �� ����������� ������� ������ ������������ ����������.|��";
                for (int i = 0; i < 5; i++)
                {
                    authorSprite[i] = charachters[0];
                }

                lines[6] = "�� �� ���� �� ������������, � ���� ������� ������ �����. �� � ����� ��, ��� �� �� �������� ����������� � ��������� ������ ���������� �������, ��-������ ����� �������,��� ���������� ����� 15-��!|���������";
                lines[7] = "�� ������ ����������. �� ���� ������� ��� ������ �� ����� �����.|��";
                authorSprite[6] = charachters[1];
                authorSprite[7] = charachters[1];

                lines[8] = "���-���, �� ������ �� ������? �������, ��� ���� � ������� �� ����� �������, �� � ������ �� �������� �����.|���������";
                lines[9] = "������, ������ ������! �� ����� �������� ���. ���� �� ��������.|��";
                lines[10] = "��� ���������� ���� � �������.|���������";
                lines[11] = "����� ���������, ���������� �� ������ ��������, ��� ��������� �����, ��� ���� ������� ��������, �������� ���, ���������������� ����������!|��";
                lines[12] = "� �������� ����� ������ � ����� �����, ���� �� ��������� � �� ������ ��� ����� ������|���������";
                lines[13] = "���! � ������ �� ���� ���� �������������� ������, ������� ��������� ������ �������� ���������� ��� ���� ������ �� ����� ��������.|��";
                lines[14] = "������� ��� ���������,������� �� ��������� ���� � ���� ������ �������������� �����,�� �������� ��� ��� ����� � � ���� �� ����� �����.|���������";
                lines[15] = "��� �� �����, � ������, ������� �������� � ����� �������, �������� ���������� �� ����� ������.|��";
                lines[16] = "� ������ ������ �� ����� ���|���������";
                authorSprite[8] = charachters[0];
                authorSprite[9] = charachters[0];
                authorSprite[10] = charachters[0];
                authorSprite[11] = charachters[0];
                authorSprite[12] = charachters[0];
                authorSprite[13] = charachters[0];
                authorSprite[14] = charachters[0];
                authorSprite[15] = charachters[0];
                authorSprite[16] = charachters[0];

                break;
            case 10:
                lines[0] = "� �������, ��� �� ����� �� ����� ���, ��������.|���������";
                lines[1] = "��� ������?|��";
                lines[2] = "��-��. ����� ������. ��� ���� ���������|���������";
                lines[3] = "��� ������� ������� ������� ����.|��";
                lines[4] = "��� ������� ��� ����������.|���������";
                lines[5] = "������...|��";
                for(int i = 0; i < 5; i++)
                {
                    authorSprite[i] = charachters[0];
                }
                break;
            case 12:
                lines[0] = "� �������, ��� �������� ��� �������� � ������ ������� ������ ���� ���� � �� ������� � ����� ������ �������, �� ��� ��, ������� ��������, ���� ����� ��������� ����?|���������";
                lines[1] = "������, ���������� ������ �������� ��������� ������� ������������ ����! ������� ��� ����� ���������� ���� ������ �������� ���� ����� ��������� ��������|��";
                authorSprite[0] = charachters[0];
                authorSprite[1] = charachters[0];
                break;
            case 14:
                lines[0] = "�������� ���� ��������� �����, ����� �� ��������������� �������� ���������.|��";
                GameObject.FindWithTag("DontDestroy").GetComponent<DontDestroy>().money += 100;
                authorSprite[0] = charachters[0];

                lines[1] = "������� � �� ���� ����� �������.|���������";
                lines[2] = "����� ������ ������, �� ��� ��� ������� ���������|��";
                lines[3] = "�������� ����������� �����. ���.. ������ �������� ���� ����� ���������� �������� ��� ���������� ����, ���������� �������, ��-������ ����� �������,��� ���������� ����� 15-��!|���������";
                lines[4] = "� ��� ������������������ ��������� ��-������� �� �������� �������� �-����, �������� �� ����������� �������� � ��-���� ����.|���������";
                lines[5] = "������ ����� ���������� �-����� ��-������ ����� �������,��� ���������� ����� 15-��, �������������� �-� ���� ��-�������� �� ��� ��-����:|���������";
                lines[6] = "�������� ����� ������, ��� ������ ��� ��� 1000 ������� ��� ����� ����. ����� ���, ��� ����� �����, ���������.|���������";
                lines[7] = "��� �����, ��� ������ ���� � ���� ����� ��������� ���� ����, ������� �� ������ ��������� � ������� ������� ��������, ���������.|���������";
                lines[8] = "� ��� ��� �����, �� ����� ������ �� ��� ����� ��� �������� ������ ���� �������, ���������, �����.|���������";
                lines[9] = "�� ����� ������� ��� ���,� ��� ���� ����� �������, ���������, ��� � ����� ���������� ��� ������, ���� ��, ���������, ������� ��� 100 ������!|���������";
                lines[10] = "�� ���� � �����. ��� �� ������, ���������, � ��� ������� ����� �� ���������! ����� ��|���������";
                lines[11] = "� ������ ����� �������,��� ���������� ����� 15-�� ����� ����� ��� ���� ����� ������ ��������. �������� ������, ��� �-����� ��-���� �������� � ��-���������!|���������";
                lines[12] = "��� ������, � ��� ������ ����� ���, ����� ����������, ������?|��";
                lines[13] = "�������� �� ��������, ��� ��-���� ����� ��� ����������, ����� ��������� ��� ������������� ������, �� � ������� ��� ��� ������ ����.|���������";
                lines[14] = "��� ������ �� �� ������ ������� � ����� � ���. ������ �� ������, � ��� ������ �����?|��";
                lines[15] = "�� �� ������ ����� ���, ���� �� ����� � ���� ��� ��� �����������. � ���������� 1000 �������. ������ ������ �� ������, �� � ��� ��������� ��� ���� �����, ������� ���������, �� ���� ������ ����� ��������|���������";
                lines[16] = "��� ��� ����������� ��� ������������, �� ����� ����������� ��� ����� ������ � ����� ������|��";
                lines[17] = "��� �-����� ����� � ��������� ��������, �� � ��������, ����� ��� �� ����������.|���������";
                lines[18] = "� ��������� ��� ������, �� ������ ��� ������������� ����� �� �����  ������� � ������� ������, � � ����� ������, � ����� �������� ��������� ���������, �� �������� ��� ������� ������, ������� �� ��������.|���������";
                lines[19] = "� ������ ������ ������, ������ ������ ��� � ��� ��� ���.|���������";
                lines[20] = "�� ���� � ������, �������� ���� ������.|��";
                lines[21] = "� ���� �� ����� ������� ����� ����, �� ��� ��� �� ������ � ���������|���������";
                for (int i = 0; i < 21; i++)
                {
                    authorSprite[i] = charachters[1];
                }
                break;

        }

        lines = lines.Where(x => x != null).ToArray();
        text.text = string.Empty;
        nameField.text = lines[index].Split("|")[1];
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
            Debug.Log("���� �����, ���");
        }
       
    }
    private void Update()
    {
            if(Input.GetMouseButtonDown(0))
            {
                if (text.text == lines[index].Split("|")[0])
                {
                    IsNextLine();
                }
                else
                {
                    StopAllCoroutines();
                    text.text = lines[index].Split("|")[0];
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
        GameObject.FindWithTag("Speaker").GetComponent<SpriteRenderer>().sprite = authorSprite[index];
        string[] splitted = lines[index].Split("|");
        nameField.text = splitted[1];
        foreach (char c in splitted[0].ToCharArray())
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
