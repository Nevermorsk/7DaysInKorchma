using System;
using System.Collections;
using UnityEngine;

public class ColorCheck : MonoBehaviour
{

    public float cookingTime = 30f;
    public float secondCookingTime = 10f;
    public float colorThreshold = 0.05f;
    public Color targetColor;
    public Sprite pancake;
    public Sprite cookedPancake;
    public Sprite cap;
    public bool pancakeMakeFirst = false;
    public bool pancakeMakeFinal = false;
    private SpriteRenderer spriteRenderer;
    
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (!pancakeMakeFirst && CheckColor(targetColor)) {
            spriteRenderer.sprite = cap;
            pancakeMakeFirst = true;
            Debug.Log("StartTimer1");
            StartCoroutine(Delay1(cookingTime));
            
        }
        else if (!pancakeMakeFinal && ingredientsScript.addedIngredient != null)
        {
            spriteRenderer.sprite = cap;
            pancakeMakeFinal = true;
            Debug.Log("StartTimer2");
            ingredientsScript.canAdd = false;
            StartCoroutine(Delay2(secondCookingTime));
          
        }
    }

    IEnumerator Delay1(float time)
    {
        yield return new WaitForSeconds(time);
        Debug.Log("EndTimer");
        spriteRenderer.sprite = pancake;
        ingredientsScript.canAdd = true;
    }    
    IEnumerator Delay2(float time)
    {
        yield return new WaitForSeconds(time);
        Debug.Log("EndTimer");
        spriteRenderer.sprite = cookedPancake;

    }
    public bool CheckColor(Color targetColor)
    {
        float alphaArea = spriteRenderer.color.a * spriteRenderer.bounds.size.x * spriteRenderer.bounds.size.y;

        // Вычисляем относительную площадь целевого цвета
        float targetArea = 0f;
        foreach (var sprite in spriteRenderer.sprite.texture.GetPixels())
        {
            if (sprite == targetColor)
            {
                targetArea += 1f;
            }
        }
        targetArea /= spriteRenderer.sprite.texture.width * spriteRenderer.sprite.texture.height;

        // Сравниваем относительные площади цвета и выводим результат
        if (alphaArea * colorThreshold > targetArea)
        {
            Debug.Log("Color did not match.");
            Debug.Log($"{targetArea} > {alphaArea * colorThreshold}");
            return false;
        }
        else
        {
            Debug.Log("Color matched!");
            Debug.Log($"{targetArea} > {alphaArea * colorThreshold}");
            return true; 
        }
    }
}