using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroy : MonoBehaviour
{
    public static int counter;
    private static int money;
    private static int day = 0;
    public static int Day { get => day; set {
            day = value;
            loadDialog();
        } }

    public static int Money { get => money; set => money = value; }

    public static void loadDialog()
    {
        dayDialogue = Replica.MakeQueue($"dialogues_day{day}");
    }

    public static Dictionary<string, bool> byedItems = new Dictionary<string, bool>{
        { "apple", true },
        { "sguxa", false },
        { "salmon", false },
        { "chocolatepaste", false },
        { "strawberries", false },
        { "sugar", true },
        { "upgrade", false }
};

    public static Queue<Replica> dayDialogue;
    public AudioSource addMoney;
    public TextMeshProUGUI text;
    private static bool firstStart = true;

    public static bool moneyChange(int money)
    {
        Debug.Log($"{money} {DontDestroy.money}");
        if (money < 0 && DontDestroy.money >= money * -1)
        {
            DontDestroy.money += money;
            return true;
        }
        else if (money > 0)
        {
            GameObject.FindGameObjectWithTag("DontDestroy").GetComponent<DontDestroy>().addMoney.Play();
            DontDestroy.money += money;
            Debug.Log($"{money} {DontDestroy.money}");
            return true;
        }
        else
        {
            Debug.Log("нет денег");
            return false;
        }
    }

    void Start()
    {
        if (firstStart)
        {
            Day = 1;
            firstStart = false;
        }

        GameObject[] objs = GameObject.FindGameObjectsWithTag("DontDestroy");
        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);

    }
    
    public void FixedUpdate()
    {
        text.text = money.ToString();
        string SceneName = SceneManager.GetActiveScene().name;
        if (SceneName != "Window 1" && SceneName != "Day 1")
        {
            GameObject.FindGameObjectWithTag("money").SetActive(false);
        }
        else
        {
            GameObject.FindGameObjectWithTag("money").SetActive(true);
        }
    }
}
