using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MoneyScript : MonoBehaviour
{
    private int money;
    private TextMeshProUGUI text;

    private void Start()
    {
        money = GameObject.FindWithTag("DontDestroy").GetComponent<DontDestroy>().money;
        text = GetComponent<TextMeshProUGUI>();
        text.text = money+"ð";
    }

    private void Update()
    {
        text.text = money + "p";
    }
}
