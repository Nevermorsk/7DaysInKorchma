using FreeDraw;
using System;
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class ColorCheck : MonoBehaviour
{
    [SerializeField] private Sprite circle;
    [SerializeField] private GameObject SceneSwitcher;

    public float cookingTime = 30f;
    public float secondCookingTime = 10f;
    public float colorThreshold = 0.05f;
    public Color targetColor;
    public Sprite pancake;
    public Sprite cookedPancake;
    public Sprite cap;
    public GameObject resetBtn;
    public AudioSource cookingSound;
    [HideInInspector] public bool pancakeMakeFirst = false;
    [HideInInspector] public bool pancakeMakeFinal = false;
    [HideInInspector] public bool pancackeDone = false;
    [HideInInspector] public static bool vineNeed = false;
    private SpriteRenderer spriteRenderer;
    
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = circle;
        ingredientsScript.addedIngredient = null;
        BarrelDragAndDrop.isFilled = false;

    }

    void Update()
    {

        if (pancakeMakeFinal && !vineNeed && OrderSystem.receipt == "")
        {
            SceneSwitcher.SetActive(true);
        } else if (pancackeDone && !vineNeed)
        {
            SceneSwitcher.SetActive(true);
        } else if (pancackeDone && BarrelDragAndDrop.isFilled) 
        {
            SceneSwitcher.SetActive(true);
        }

        if (!pancakeMakeFirst && CheckColor(targetColor)) {
            spriteRenderer.sprite = cap;
            pancakeMakeFirst = true;
            cookingSound.Play();
            StartCoroutine(Delay1(cookingTime));
            
        }
        else if (!pancackeDone && ingredientsScript.addedIngredient != null && OrderSystem.receipt != "")
        {
            spriteRenderer.sprite = cap;
            ingredientsScript.canAdd = false;
            cookingSound.Play();
            StartCoroutine(Delay2(secondCookingTime));
          
        }

    }

    IEnumerator Delay1(float time)
    {
        yield return new WaitForSeconds(time);
        spriteRenderer.sprite = pancake;
        ingredientsScript.canAdd = true;
        cookingSound.Stop();
        pancakeMakeFinal = true;
    }    
    IEnumerator Delay2(float time)
    {
        yield return new WaitForSeconds(time);
        spriteRenderer.sprite = cookedPancake;
        cookingSound.Stop();
        if (OrderSystem.receipt == ingredientsScript.addedIngredient)
        {
            pancackeDone = true;
        } else
        {
            resetBtn.SetActive(true);
        }
    }
    public void resetClc()
    {
        GetComponent<Drawable>().ResetCanvas();
        spriteRenderer.sprite = circle;
        ingredientsScript.addedIngredient = null;
        pancakeMakeFirst = false;
        pancakeMakeFinal = false;
        pancackeDone = false;
        BarrelDragAndDrop.isFilled = false;
        GameObject.FindGameObjectWithTag("resetBtn").SetActive(false);
    }
    public bool CheckColor(Color targetColor)
    {
        float alphaArea = spriteRenderer.color.a * spriteRenderer.bounds.size.x * spriteRenderer.bounds.size.y;

        float targetArea = 0f;
        foreach (var sprite in spriteRenderer.sprite.texture.GetPixels())
        {
            if (sprite == targetColor)
            {
                targetArea += 1f;
            }
        }
        targetArea /= spriteRenderer.sprite.texture.width * spriteRenderer.sprite.texture.height;

        if (alphaArea * colorThreshold > targetArea)
        {
            return false;
        }
        else
        {
            return true; 
        }
    }
}