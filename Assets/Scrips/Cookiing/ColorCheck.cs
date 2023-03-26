using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ColorCheck : MonoBehaviour
{
    [SerializeField] private Sprite circle;
   // [SerializeField] private Button _button;

    public float cookingTime = 30f;
    public float secondCookingTime = 10f;
    public float colorThreshold = 0.05f;
    public Color targetColor;
    public Sprite pancake;
    public Sprite cookedPancake;
    public Sprite cap;
    [SerializeField] private Sprite _background;
    public GameObject resetBtn;
    public AudioSource cookingSound;
    [HideInInspector] public bool pancakeMakeFirst = false;
    [HideInInspector] public bool pancakeMakeFinal = false;
    [HideInInspector] public bool done = false;
    private SpriteRenderer spriteRenderer;
    
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = circle;
        ingredientsScript.addedIngredient = null;
      //  _button.onClick.AddListener(Rearm);
        
    }
    void Rearm(){
     SceneManager.LoadScene("Day 1");   
     
    }
    void Update()
    {
        
        if (!pancakeMakeFirst && CheckColor(targetColor)) {
            spriteRenderer.sprite = cap;
            pancakeMakeFirst = true;
            cookingSound.Play();
            StartCoroutine(Delay1(cookingTime));
            Debug.Log(gameObject.name);            
            
        }
        else if (!pancakeMakeFinal && ingredientsScript.addedIngredient != null)
        {
            spriteRenderer.sprite = cap;
            pancakeMakeFinal = true;
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
    }    
    IEnumerator Delay2(float time)
    {
        yield return new WaitForSeconds(time);
        spriteRenderer.sprite = cookedPancake;
        cookingSound.Stop();
        if (OrderSystem.receipt == ingredientsScript.addedIngredient)
        {
            done = true;
        } else
        {
            resetBtn.SetActive(true);
        }
    }
    public void resetClc()
    {
        spriteRenderer.sprite = circle;
        ingredientsScript.addedIngredient = null;
        pancakeMakeFirst = false;
        pancakeMakeFinal = false;
        done = false;
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