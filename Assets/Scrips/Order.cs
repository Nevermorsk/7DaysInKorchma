using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
                        OrderSystem.receipt = "�����";
                        break;
                    case 3:
                        GameManager.hidden = true;
                        GameObject.FindWithTag("Order").SetActive(false);
                        GameObject.FindWithTag("FryingPan").SetActive(false);
                        GameObject.FindWithTag("OrderShadow").SetActive(false);
                        break;
                    case 5:
                        GameManager.hidden = false;
                        OrderSystem.receipt = "�����";
                        break;
                    case 7:
                        GameManager.hidden = true;
                        GameObject.FindWithTag("Order").SetActive(false);
                        GameObject.FindWithTag("FryingPan").SetActive(false);
                        GameObject.FindWithTag("OrderShadow").SetActive(false);
                        break;
                    case 9:
                        GameManager.hidden = false;
                        OrderSystem.receipt = "�����";
                        break;
                    case 11:
                        GameManager.hidden = false;
                        OrderSystem.receipt = "�����";
                        break;
                    case 13:
                        GameManager.hidden = false;
                        OrderSystem.receipt = "�����";
                        break;
                }
                break;
            case 1:
                switch (counter)
                {
                    case 1:
                        GameManager.hidden = false;
                        OrderSystem.receipt = "������";
                        break;
                    case 3:
                        GameManager.hidden = true;
                        GameObject.FindWithTag("Order").SetActive(false);
                        GameObject.FindWithTag("FryingPan").SetActive(false);
                        GameObject.FindWithTag("OrderShadow").SetActive(false);
                        break;
                    case 5:
                        GameManager.hidden = false;
                        OrderSystem.receipt = "�����";
                        break;
                    case 7:
                        GameManager.hidden = false;
                        OrderSystem.receipt = "�����";
                        break;
                    case 9:
                        GameManager.hidden = true;
                        GameObject.FindWithTag("Order").SetActive(false);
                        GameObject.FindWithTag("FryingPan").SetActive(false);
                        GameObject.FindWithTag("OrderShadow").SetActive(false);
                        break;
                }
                break;
            }
    }
}
