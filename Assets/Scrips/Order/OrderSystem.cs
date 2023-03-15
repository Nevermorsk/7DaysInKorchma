using System.Collections;
using UnityEngine;
using Image = UnityEngine.UI.Image;

public class OrderSystem : MonoBehaviour
{
    [SerializeField] private Sprite[] sprites;
    [SerializeField] private float delay;
    [SerializeField] private Sprite[] icons;

    private GameObject shadow;
    private int _currentSprite;

    /*private GameObject[] childs = new GameObject[3];*/

    public static string receipt;

    [HideInInspector] public bool timerDone = false;

    void Start()
    {
/*        for (int i = 0; i < 3; i++)
        {
            Transform childTransform = gameObject.transform.GetChild(i);
            childs[i] = childTransform.gameObject;
            Color currentColor = childs[i].GetComponent<Image>().color;
            childs[i].GetComponent<Image>().color = new Color(currentColor.r, currentColor.g, currentColor.b, 0f);
        }*/

        if (receipt != "")
        {
            Debug.Log(receipt);
            Image image = gameObject.transform.GetChild(1).gameObject.GetComponent<Image>();
            Color currentColor = image.color;
            image.color = new Color(currentColor.r, currentColor.g, currentColor.b, 1f);
            image.sprite = Resources.Load<Sprite>($"Sprites/Orders/ikonki/icon_{receipt}");
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
