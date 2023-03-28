using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroy : MonoBehaviour
{
    public static int counter;

    public static int diffuculty = 0;

    private static int day = 0;
    public static int Day { get => day; set {
            day = value;
            loadDialog();
        } }


    private static int money;
    public static float moneyModifyer = 1f;
    public static int Money { get => money; set => money = value; }

    public static void loadDialog()
    {
        dayDialogue = Replica.MakeQueue($"dialogues_day{day}");
    }

    public static Dictionary<string, bool> byedItems = new Dictionary<string, bool>{
        { "apple", false },
        { "sguxa", false },
        { "salmon", false },
        { "chocolatepaste", false },
        { "strawberries", false },
        { "sugar", true },
        { "vine", false }
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
            dontDest.playAnim((int)Unity.Mathematics.math.round(money*moneyModifyer), '+', true);
            return true;
        }
        else
        {
            Debug.Log("нет денег");

            if (DialogueSystem.currentDialog.fatalEnd == 3)
            {
                transitionScipt.LoadScene("MainMenu", "titles");
            }
            return false;
        }
    }

    public void playAnim(int money, char act, bool needSound)
    {
        if (act == '+') {
            GameObject addMoney = GameObject.FindGameObjectWithTag("money").transform.GetChild(0).gameObject;
            addMoney.GetComponent<TextMeshProUGUI>().text = $"{money} {act}";
            addMoney.GetComponent<Animator>().SetTrigger("addMoney");
        }
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
            Day = 3;
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
            GameObject.FindGameObjectWithTag("DontDestroy").transform.GetChild(0).gameObject.SetActive(false);
        }
        else
        {
            GameObject.FindGameObjectWithTag("DontDestroy").transform.GetChild(0).gameObject.SetActive(true);
        }
    }
}
