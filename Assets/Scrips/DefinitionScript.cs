using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class DefinitionScript : MonoBehaviour, IPointerDownHandler
{
    [SerializeField] private int type;

    public void OnPointerDown(PointerEventData eventData)
    {
        if (type == 0)
        {
            switch (DontDestroy.day)
            {
                case 1:
                    GameObject.FindWithTag("dialog").GetComponent<DialogueSystem>().Hide();
                    DialogueSystem.lines.Add("�������, ����, ��� ���� ����.|��");
                    DialogueSystem.lines.Add("�� ������� �����, ��� ��������, ��� � �����������.|������");
                    Sprite speaker = GameObject.FindWithTag("dialog").GetComponent<DialogueSystem>().charachters[2];
                    DialogueSystem.authorSprite.Add(speaker);
                    DialogueSystem.authorSprite.Add(speaker);
                    break;
            }
        }
        else
        {
            switch (DontDestroy.day)
            {
                case 1:
                    GameObject.FindWithTag("dialog").GetComponent<DialogueSystem>().Hide();
                    DialogueSystem.lines.Add("������, ����, ����� �������� �� ����.|��");
                    DialogueSystem.lines.Add("�� ������� �����, ��� ��������, ��� � �����������.|������");
                    Sprite speaker = GameObject.FindWithTag("dialog").GetComponent<DialogueSystem>().charachters[2];
                    DialogueSystem.authorSprite.Add(speaker);
                    DialogueSystem.authorSprite.Add(speaker);
                    break;
            }
        }
    }
}
