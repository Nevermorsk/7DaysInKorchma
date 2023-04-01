using System.Collections;
using UnityEngine;
using Image = UnityEngine.UI.Image;

public class OrderSystem : MonoBehaviour
{
    [SerializeField] private Sprite[] sprites;
    [SerializeField] private Sprite[] icons;
    [SerializeField] private GameObject SceneSwitcher;

    private GameObject shadow;
    private GameObject bagShadow;
    private int _currentSprite;

    public static string receipt;
    public static int fatalEnd;

    [HideInInspector] public static bool timerDone = false;

    void Start() 
    {
        timerDone = false;
        shadow = GameObject.FindWithTag("OrderShadow");
        bagShadow = GameObject.FindWithTag("bagShadow");

        foreach (var pair in DontDestroy.byedItems)
        {
            Debug.Log(pair);
            GameObject.Find(pair.Key).SetActive(pair.Value);
            if (pair.Key == "bag" &&  !pair.Value) bagShadow.gameObject.SetActive(false);  
        }

        if (receipt != "")
        {
            Debug.Log(receipt);
            if (receipt == null)
            {
                GameObject.FindGameObjectWithTag("FryingPan").gameObject.SetActive(false);
                SceneSwitcher.SetActive(true);
            }
            
            
            else if (DontDestroy.byedItems[receipt] && (  (DontDestroy.byedItems["vine"] && ColorCheck.vineNeed) || !ColorCheck.vineNeed ) )
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
        else if (receipt == "" && ColorCheck.vineNeed)
        {
            SceneSwitcher.SetActive(true);
        } else
        {
            StartCoroutine(Delay());
            shadow.SetActive(true);
        }


    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(DontDestroy.orderDelay);
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
