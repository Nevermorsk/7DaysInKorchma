using System;
using UnityEngine;

public class ColorCheck : MonoBehaviour
{
    public Color targetColor;
    public float colorThreshold = 0.1f;
    public Sprite pancake;
    public bool pancakeMake = false;
    private SpriteRenderer spriteRenderer;
    
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (!pancakeMake && CheckColor(targetColor)) {
            spriteRenderer.sprite = pancake;
            pancakeMake = true;
        }
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