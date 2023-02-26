using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buyingScript : MonoBehaviour
{
    [SerializeField] private Button apple;
    [SerializeField] private Button sgushenka;
    [SerializeField] private Button upgrade;

    [SerializeField] private AudioSource buySound;

    [SerializeField] private Image background;
    [SerializeField] private Sprite[] backgrounds = new Sprite[7];
    
    void Start()
    {
        background.sprite = backgrounds[DontDestroy.day];
        switch (DontDestroy.day)
        {
            case 0:
                apple.gameObject.SetActive(true);
                sgushenka.gameObject.SetActive(false);
                upgrade.gameObject.SetActive(false);
                break;           
            case 1:
                apple.gameObject.SetActive(true);
                sgushenka.gameObject.SetActive(true);
                upgrade.gameObject.SetActive(true);
                break;
        }
    }

    public void buyAppleClc() {
        buySound.Play();
        if (DontDestroy.money >= 40)
        {
            DontDestroy.money -= 40;
            apple.interactable = false;
            DontDestroy.byedItems["apples"] = true;
        }
        
    }
    public void buySgushenkaClc() {
        buySound.Play();
        if (DontDestroy.money >= 60)
        {
            DontDestroy.money -= 60;
            sgushenka.interactable = false;
            DontDestroy.byedItems["sgushenka"] = true;
        }

    }
    public void buyUpgradeClc() {
        buySound.Play();
        Debug.Log(DontDestroy.money);
        if (DontDestroy.money >= 300)
        {
            DontDestroy.money -= 300;
            upgrade.interactable = false;
            DontDestroy.byedItems["upgrade"] = true;
        }
    }    
    public void close() {
        gameObject.SetActive(false);
    }

}
