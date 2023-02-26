using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buyingScript : MonoBehaviour
{
    [SerializeField] private Button apple;
    [SerializeField] private Button sgushenka;
    [SerializeField] private Button upgrade;

    [SerializeField] private Image background;
    [SerializeField] private Sprite[] backgrounds = new Sprite[7];
    
    void Start()
    {
        DontDestroy.money = 400;
        background.sprite = backgrounds[DontDestroy.day - 1];
        switch (DontDestroy.day)
        {
            case 1:
                apple.gameObject.SetActive(true);
                sgushenka.gameObject.SetActive(false);
                upgrade.gameObject.SetActive(false);
                break;           
            case 2:
                apple.gameObject.SetActive(true);
                sgushenka.gameObject.SetActive(true);
                upgrade.gameObject.SetActive(true);
                break;


        }
    }

    public void buyAppleClc() {
        if (DontDestroy.money >= 40)
        {
            DontDestroy.money -= 40;
            apple.interactable = false;
            DontDestroy.byedItems["apples"] = true;
        }
        
    }
    public void buySgushenkaClc() {
        if (DontDestroy.money >= 60)
        {
            DontDestroy.money -= 60;
            sgushenka.interactable = false;
            DontDestroy.byedItems["sgushenka"] = true;
        }

    }
    public void buyUpgradeClc() {
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
