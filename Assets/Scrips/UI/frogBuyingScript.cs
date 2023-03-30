using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class frogBuyingScript : MonoBehaviour
{
    [SerializeField] private Button buyBag;
    [SerializeField] private Button buyJabba;

    [SerializeField] private Image bagBackground;
    [SerializeField] private Image jabbaBackground;

    [SerializeField] private AudioSource buySound;
    [HideInInspector] public static bool buyed = false;
    
    // Start is called before the first frame update
    void Start()
    {
        switch (DontDestroy.Day)
        {
            case 3:
                buyBag.gameObject.SetActive(true);
                bagBackground.gameObject.SetActive(true);
                buyJabba.gameObject.SetActive(false);
                jabbaBackground.gameObject.SetActive(false);
                break;            
            case 5:
                buyBag.gameObject.SetActive(false);
                bagBackground.gameObject.SetActive(false);
                buyJabba.gameObject.SetActive(true);
                jabbaBackground.gameObject.SetActive(true);
                break;
        }
    }

    public void buyBagClc()
    {
        if (DontDestroy.moneyChange(-150))
        {
            buySound.Play();
            DontDestroy.byedItems["bag"] = true;
            close();
        }
    }

    public void buyJabbaClc()
    {
        if (DontDestroy.moneyChange(-100))
        {
            buySound.Play();
            DontDestroy.byedItems["jabba"] = true;
            buyed = true;
            close();
        }
    }
    public void close()
    {
        gameObject.transform.GetChild(0).gameObject.SetActive(false);
    }
}
