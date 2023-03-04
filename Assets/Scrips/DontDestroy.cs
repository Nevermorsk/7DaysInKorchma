using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroy : MonoBehaviour
{
    public static int counter;
    public static int money;
    public static int day;

    public static Dictionary<string, bool> definitions = new Dictionary<string, bool>
    {
        { "day2", false }
    };

    public static Dictionary<string, bool> byedItems = new Dictionary<string, bool>{
        { "apples", false },
        { "sgushenka", false },
        { "salomon", false },
        { "nutella", false },
        { "starberry", false },
        { "sugar", true },
        { "upgrade", false }
};
    private static TextMeshProUGUI text;

    void Start()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("DontDestroy");
        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);

        text = GameObject.FindGameObjectWithTag("money").GetComponent<TextMeshProUGUI>();

    }
    
    public void FixedUpdate()
    {
        text.text = money.ToString();
        string SceneName = SceneManager.GetActiveScene().name;
        if (SceneName != "Window 1" && SceneName != "Day 1")
        {

        }
    }
}
