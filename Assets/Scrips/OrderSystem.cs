using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;

public class OrderSystem : MonoBehaviour
{
    [SerializeField] private Sprite[] sprites;
    [SerializeField] private float delay;
    [SerializeField] private Sprite[] icons;

    private GameObject shadow;
    private int _currentSprite;

    private GameObject[] childs = new GameObject[3];

    public string receipt;

    [HideInInspector] public bool timerDone = false;

    void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            Transform childTransform = gameObject.transform.GetChild(i);
            childs[i] = childTransform.gameObject;
            Color currentColor = childs[i].GetComponent<Image>().color;
            childs[i].GetComponent<Image>().color = new Color(currentColor.r, currentColor.g, currentColor.b, 0f);
        }

            if (receipt != "")
            {
                Image image = childs[1].GetComponent<Image>();
                Color currentColor = image.color;
                image.color = new Color(currentColor.r, currentColor.g, currentColor.b, 1f);

                switch (receipt)
                {
                  case "сахар":
                    image.sprite = icons[5];
                    break;
                  case "€блоки":
                    image.sprite = icons[0];
                    break;
                  case "клубника":
                    image.sprite = icons[4];
                    break;
                  case "сгущенка":
                    image.sprite = icons[3];
                    break;
                  case "паста":
                    image.sprite = icons[1];
                    break;
                  case "сЄмга":
                    image.sprite = icons[2];
                    break;
                }
            }

        shadow = GameObject.FindWithTag("OrderShadow");
        _currentSprite = 0;
        StartCoroutine(Delay());
        shadow.SetActive(true);
    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(delay);
        _currentSprite++;
        NextSprite();
    }

    private void NextSprite()
    {
        if (_currentSprite == sprites.Length)
        {
            Destroy(gameObject);
            StopAllCoroutines();
            shadow.SetActive(false);
            timerDone = true;
        }
        else
        {
            GetComponent<Image>().sprite = sprites[_currentSprite];
            StartCoroutine(Delay());
        }
    }
}
