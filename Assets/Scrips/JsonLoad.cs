using System.Collections.Generic;
using Newtonsoft.Json;
using UnityEditor.VersionControl;
using UnityEngine;

public class JsonLoad : MonoBehaviour
{
    public string fileName;
    private Queue<Replica> dialogues_day1;
    public void Start()
    {
        dialogues_day1 = Replica.MakeQueue(fileName);
    }
    public void BtnClc()
    {
        var dial = dialogues_day1.Dequeue();
        Debug.Log($"{dial.author} - {dial.text} ({dial.sprite}|{dial.audio}|{dial.action})");
    }
}
