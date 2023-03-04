using UnityEngine;
using UnityEngine.EventSystems;

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
                    DialogueSystem.lines.Add("�������, ����...|��");
                    DialogueSystem.audios.Add("audio/dialogue/gg/gg27");
                    DialogueSystem.lines.Add("�� ������� �����, ��� ��������, ��� � �����������.|������");
                    DialogueSystem.audios.Add("audio/dialogue/biduin/biduin3");
                    Sprite speaker = GameObject.FindWithTag("dialog").GetComponent<DialogueSystem>().charachters[2];
                    DialogueSystem.authorSprite.Add(speaker);
                    DialogueSystem.authorSprite.Add(speaker);
                    DialogueSystem.canNextDay = true;
                    break;
            }
        }
        else
        {
            switch (DontDestroy.day)
            {
                case 1:
                    GameObject.FindWithTag("dialog").GetComponent<DialogueSystem>().Hide();
                    DialogueSystem.lines.Add("������, ����, ����� �������� �� ����...|��"); 
                    DialogueSystem.audios.Add("audio/dialogue/gg/gg26");
                    DialogueSystem.lines.Add("�� ������� �����, ��� ��������, ��� � �����������.|������");
                    DialogueSystem.audios.Add("audio/dialogue/biduin/biduin3");
                    Sprite speaker = GameObject.FindWithTag("dialog").GetComponent<DialogueSystem>().charachters[2];
                    DialogueSystem.authorSprite.Add(speaker);
                    DialogueSystem.authorSprite.Add(speaker);
                    DialogueSystem.canNextDay = true;
                    break;
            }
        }
    }
}
