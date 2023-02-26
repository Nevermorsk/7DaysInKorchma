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
                    DialogueSystem.lines.Add("Конечно, бать, вот тебе блин.|Вы");
                    DialogueSystem.lines.Add("Ты главное помни, как аукнется, так и откликнется.|Бедуин");
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
                    DialogueSystem.lines.Add("Прости, бать, никак выручить не могу.|Вы");
                    DialogueSystem.lines.Add("Ты главное помни, как аукнется, так и откликнется.|Бедуин");
                    Sprite speaker = GameObject.FindWithTag("dialog").GetComponent<DialogueSystem>().charachters[2];
                    DialogueSystem.authorSprite.Add(speaker);
                    DialogueSystem.authorSprite.Add(speaker);
                    break;
            }
        }
    }
}
