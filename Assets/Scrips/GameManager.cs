using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject[] ingridients;
    [SerializeField] private GameObject[] vino;
    [SerializeField] private GameObject SceneSwitcher;

    private GameObject Order;
    private GameObject FryingPan;

    private void Start()
    {
        Order = GameObject.FindWithTag("Order");
        FryingPan = GameObject.FindWithTag("FryingPan");

        for(int i = 0; i < 5; i++)
        {
            ingridients[i].SetActive(false);
        }

        for(int i = 0; i < 3; i++)
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
        if (Order.GetComponent<OrderSystem>().timerDone)
        {
            Debug.Log("You loser");
        }

        if (FryingPan.GetComponent<ColorCheck>().done)
        {
            SceneSwitcher.SetActive(true);
        }
    }
}
