using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Dictionary<string, GameObject> ingridients;
    [SerializeField] private GameObject[] vino;
    [SerializeField] private GameObject SceneSwitcher;

    private GameObject FryingPan;

    private void Awake()
    {
/*        int counter = DontDestroy.counter;
        Order.DefineOrder(DontDestroy.Day, DontDestroy.counter);*/
    }

    private void Start()
    {
        FryingPan = GameObject.FindWithTag("FryingPan");

        foreach (var pair in DontDestroy.byedItems)
        {
            // Debug.Log(pair);
            GameObject.Find(pair.Key).SetActive(pair.Value);
        }

        for (int i = 0; i < 3; i++)
        {
            vino[i].SetActive(false);
        }

        SceneSwitcher.SetActive(false);

        FryingPan.GetComponent<ColorCheck>().done = false;
        FryingPan.GetComponent<ColorCheck>().pancakeMakeFirst = false;
        FryingPan.GetComponent<ColorCheck>().pancakeMakeFinal = false;

    }

   void Update()
    {
        if (FryingPan.GetComponent<ColorCheck>().done)
        {
            SceneSwitcher.SetActive(true);
        }
    }
}
