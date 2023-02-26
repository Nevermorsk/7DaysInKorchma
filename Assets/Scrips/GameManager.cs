using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Dictionary<string, GameObject> ingridients;
    [SerializeField] private GameObject[] vino;
    [SerializeField] private GameObject SceneSwitcher;

    private GameObject FryingPan;

    private bool hidden;

    private void Awake()
    {
        int counter = DontDestroy.counter;
/*        GameObject ParentIngred = GameObject.FindGameObjectWithTag("ingredients");
        ingridients = new Dictionary<string, GameObject> {
            { "apples", GameObject.Find("apples") },
            { "sgushenka", GameObject.Find("sgushenka") },
            { "salomon", GameObject.Find("salomon") },
            { "nutella", GameObject.Find("apples") },
            { "starberry", GameObject.Find("nutella") },
            { "sugar", GameObject.Find("sugar") }
        };*/
        switch (counter)
        {
            case 1:
                OrderSystem.receipt = "сахар";
                break;
            case 3:
                hidden = true;
                GameObject.FindWithTag("Order").SetActive(false);
                GameObject.FindWithTag("FryingPan").SetActive(false);
                GameObject.FindWithTag("OrderShadow").SetActive(false);
                break;
            case 5:
                OrderSystem.receipt = "сахар";
                break;
            case 7:
                hidden = true;
                GameObject.FindWithTag("Order").SetActive(false);
                GameObject.FindWithTag("FryingPan").SetActive(false);
                GameObject.FindWithTag("OrderShadow").SetActive(false);
                break;
            case 9:
                OrderSystem.receipt = "сахар";
                break;
            case 11:
                OrderSystem.receipt = "сахар";
                break;
            case 13:
                OrderSystem.receipt = "сахар";
                break;
        }
    }

    private void Start()
    {
        if (!hidden)
        {
            FryingPan = GameObject.FindWithTag("FryingPan");
        }

        foreach (var pair in DontDestroy.byedItems)
        {
            Debug.Log(pair);
            GameObject.Find(pair.Key).SetActive(pair.Value);
        }


/*        for (int i = 0; i < 6; i++)
        {
            ingridients[i].SetActive(false);
        }*/

        for (int i = 0; i < 3; i++)
        {
            vino[i].SetActive(false);
        }

        if (!hidden) {
            SceneSwitcher.SetActive(false);

            FryingPan.GetComponent<ColorCheck>().done = false;
            FryingPan.GetComponent<ColorCheck>().pancakeMakeFirst = false;
            FryingPan.GetComponent<ColorCheck>().pancakeMakeFinal = false;
        } else
        {
            SceneSwitcher.SetActive(true);
        }
    }

   void Update()
    {
        if (!hidden) { 
            if (FryingPan.GetComponent<ColorCheck>().done)
            {
                SceneSwitcher.SetActive(true);
            }
        }
    }
}
