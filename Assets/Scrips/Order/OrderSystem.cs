using System.Collections;
using UnityEngine;
using Image = UnityEngine.UI.Image;

public class OrderSystem : MonoBehaviour
{
    [SerializeField] private Sprite[] sprites;
    [SerializeField] private float delay;
    [SerializeField] private Sprite[] icons;
    [SerializeField] private GameObject SceneSwitcher;

    private GameObject shadow;
    private int _currentSprite;


    public static string receipt;
    public static int fatalEnd;

    [HideInInspector] public static bool timerDone = false;

    void Start() 
    {   
        timerDone = false;
        shadow = GameObject.FindWithTag("OrderShadow");

        foreach (var pair in DontDestroy.byedItems)
        {
            Debug.Log(pair);
            GameObject.Find(pair.Key).SetActive(pair.Value);
        }

        if (receipt != "")
        {
            Debug.Log(receipt);
            

            if (DontDestroy.byedItems[receipt] && (  (DontDestroy.byedItems["vine"] && ColorCheck.vineNeed) || !ColorCheck.vineNeed ) )
            {
                Image image = gameObject.transform.GetChild(1).gameObject.GetComponent<Image>();
                Color currentColor = image.color;
                image.color = new Color(currentColor.r, currentColor.g, currentColor.b, 1f);
                image.sprite = Resources.Load<Sprite>($"Sprites/Orders/ikonki/icon_{receipt}");

                
                _currentSprite = 0;
                StartCoroutine(Delay());
                shadow.SetActive(true);
            } else {
                timerDone = true;
                GameObject.FindGameObjectWithTag("FryingPan").gameObject.SetActive(false);
                SceneSwitcher.SetActive(true);

            }
        }
        else
        {
            StartCoroutine(Delay());
            shadow.SetActive(true);
        }


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
            SceneSwitcher.SetActive(true);
        }
        else
        {
            GetComponent<Image>().sprite = sprites[_currentSprite];
            StartCoroutine(Delay());
        }
    }
}
