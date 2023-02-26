using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Order : MonoBehaviour
{
    public static void DefineOrder(int day, int counter)
    {
        switch(day) {
            case 0:
                switch (counter)
                {
                    case 1:
                        GameManager.hidden = false;
                        OrderSystem.receipt = "сахар";
                        break;
                    case 3:
                        GameManager.hidden = true;
                        GameObject.FindWithTag("Order").SetActive(false);
                        GameObject.FindWithTag("FryingPan").SetActive(false);
                        GameObject.FindWithTag("OrderShadow").SetActive(false);
                        break;
                    case 5:
                        GameManager.hidden = false;
                        OrderSystem.receipt = "сахар";
                        break;
                    case 7:
                        GameManager.hidden = true;
                        GameObject.FindWithTag("Order").SetActive(false);
                        GameObject.FindWithTag("FryingPan").SetActive(false);
                        GameObject.FindWithTag("OrderShadow").SetActive(false);
                        break;
                    case 9:
                        GameManager.hidden = false;
                        OrderSystem.receipt = "сахар";
                        break;
                    case 11:
                        GameManager.hidden = false;
                        OrderSystem.receipt = "сахар";
                        break;
                    case 13:
                        GameManager.hidden = false;
                        OrderSystem.receipt = "сахар";
                        break;
                }
                break;
            case 1:
                switch (counter)
                {
                    case 1:
                        GameManager.hidden = false;
                        OrderSystem.receipt = "яблоки";
                        break;
                    case 3:
                        GameManager.hidden = true;
                        GameObject.FindWithTag("Order").SetActive(false);
                        GameObject.FindWithTag("FryingPan").SetActive(false);
                        GameObject.FindWithTag("OrderShadow").SetActive(false);
                        break;
                    case 5:
                        GameManager.hidden = false;
                        OrderSystem.receipt = "сахар";
                        break;
                    case 7:
                        GameManager.hidden = false;
                        OrderSystem.receipt = "сахар";
                        break;
                    case 9:
                        GameManager.hidden = true;
                        GameObject.FindWithTag("Order").SetActive(false);
                        GameObject.FindWithTag("FryingPan").SetActive(false);
                        GameObject.FindWithTag("OrderShadow").SetActive(false);
                        break;
                    case 11:
                        if (DontDestroy.definitions["day2"])
                        {
                            GameManager.hidden = false;
                            OrderSystem.receipt = "сахар";
                        } else
                        {
                            GameManager.hidden = true;
                            GameObject.FindWithTag("Order").SetActive(false);
                            GameObject.FindWithTag("FryingPan").SetActive(false);
                            GameObject.FindWithTag("OrderShadow").SetActive(false);
                        }
                        break;
                    case 13:
                        SceneManager.LoadScene("End");
                        break;
                }
                break;
            }
    }
}
