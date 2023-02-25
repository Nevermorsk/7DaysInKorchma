using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MoneyScript : MonoBehaviour
{
    public int money;
    private TextMeshProUGUI text;

    private void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
        text.text = money+"ð";
    }

    private void Update()
    {
        text.text = money + "p";
    }
}
