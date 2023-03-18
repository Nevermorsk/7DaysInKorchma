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
        DontDestroy dontDest = GameObject.FindGameObjectWithTag("DontDestroy").GetComponent<DontDestroy>();
        if (money < 0 && DontDestroy.money >= money * -1)
        {
            dontDest.playAnim(money*-1, '-', false);
            return true;
        }
        else if (money > 0)
        {
            dontDest.playAnim(money, '+', true);
            return true;
        }
        else
        {
            Debug.Log("нет денег");
            return false;
        }
    }

    public void playAnim(int money, char act, bool needSound)
    {
        GameObject addMoney = GameObject.FindGameObjectWithTag("money").transform.GetChild(0).gameObject;
        addMoney.GetComponent<TextMeshProUGUI>().text = $"{money} {act}";
        addMoney.GetComponent<Animator>().SetTrigger("addMoney");
        StartCoroutine(pay(act == '+' ? money : money * -1, needSound));

    }

    IEnumerator pay(int newMoney, bool needSound) {
        yield return new WaitForSeconds(0.4f);
        if (needSound) { addMoney.Play(); }
        yield return new WaitForSeconds(1.2f);
        money += newMoney;
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
