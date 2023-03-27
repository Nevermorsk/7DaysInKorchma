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
        try { 
            background.sprite = backgrounds[DontDestroy.Day-1];
        } catch { }
        switch (DontDestroy.Day)
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

        if (DontDestroy.moneyChange(-40))
        {
            buySound.Play();
            apple.interactable = false;
            DontDestroy.byedItems["apple"] = true;
        }
        
    }
    public void buySgushenkaClc() {
 
        if (DontDestroy.moneyChange(-60))
        {
            buySound.Play();
            sgushenka.interactable = false;
            DontDestroy.byedItems["sguha"] = true;
        }

    }
    public void buyUpgradeClc() {
        
        if (DontDestroy.moneyChange(-300))
        {
            buySound.Play();
            upgrade.interactable = false;
            DontDestroy.byedItems["upgrade"] = true;
        }
    }    
    public void close() {
        gameObject.transform.GetChild(0).gameObject.SetActive(false);
    }

}
