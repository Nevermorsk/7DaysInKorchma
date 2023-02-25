using System;
using System.Collections;
using UnityEngine;

public class ColorCheck : MonoBehaviour
{
    [SerializeField] private Sprite circle;

    public float cookingTime = 30f;
    public float secondCookingTime = 10f;
    public float colorThreshold = 0.05f;
    public Color targetColor;
    public Sprite pancake;
    public Sprite cookedPancake;
    public Sprite cap;
    [HideInInspector] public bool pancakeMakeFirst = false;
    [HideInInspector] public bool pancakeMakeFinal = false;
    [HideInInspector] public bool done = false;
    private SpriteRenderer spriteRenderer;
    
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = circle;
        ingredientsScript.addedIngredient = null;
    }

    void Update()
    {
        if (!pancakeMakeFirst && CheckColor(targetColor)) {
            spriteRenderer.sprite = cap;
            pancakeMakeFirst = true;
            StartCoroutine(Delay1(cookingTime));
            
        }
        else if (!pancakeMakeFinal && ingredientsScript.addedIngredient != null)
        {
            spriteRenderer.sprite = cap;
            pancakeMakeFinal = true;
            ingredientsScript.canAdd = false;
            StartCoroutine(Delay2(secondCookingTime));
          
        }
    }

    IEnumerator Delay1(float time)
    {
        yield return new WaitForSeconds(time);
        spriteRenderer.sprite = pancake;
        ingredientsScript.canAdd = true;
    }    
    IEnumerator Delay2(float time)
    {
        yield return new WaitForSeconds(time);
        spriteRenderer.sprite = cookedPancake;
        done= true;
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