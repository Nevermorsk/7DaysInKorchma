using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject[] ingridients;
    [SerializeField] private GameObject[] vino;
    [SerializeField] private GameObject SceneSwitcher;

    private GameObject Order;
    private GameObject FryingPan;

    private bool hidden;

    private void Awake()
    {
        int counter = GameObject.FindWithTag("DontDestroy").GetComponent<DontDestroy>().counter;

        switch (counter)
        {
            case 1:
                GameObject.FindWithTag("Order").GetComponent<OrderSystem>().receipt = "сахар";
                break;
            case 3:
                hidden = true;
                GameObject.FindWithTag("Order").SetActive(false);
                GameObject.FindWithTag("FryingPan").SetActive(false);
                GameObject.FindWithTag("OrderShadow").SetActive(false);
                break;
            case 5:
                GameObject.FindWithTag("Order").GetComponent<OrderSystem>().receipt = "сахар";
                break;
        }
    }

    private void Start()
    {
        if (!hidden)
        {
            Order = GameObject.FindWithTag("Order");
            FryingPan = GameObject.FindWithTag("FryingPan");
        }

        for (int i = 0; i < 5; i++)
        {
            ingridients[i].SetActive(false);
        }

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
