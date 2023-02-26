using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject[] ingridients;
    [SerializeField] private GameObject[] vino;
    [SerializeField] private GameObject SceneSwitcher;

    private GameObject FryingPan;

    public static bool hidden;

    private void Awake()
    {
        int counter = DontDestroy.counter;
        Order.DefineOrder(DontDestroy.day, DontDestroy.counter);
    }

    private void Start()
    {
        if (!hidden)
        {
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
