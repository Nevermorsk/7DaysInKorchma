using System.Collections.Generic;
using Newtonsoft.Json;
using UnityEditor.VersionControl;
using UnityEngine;

public class JsonLoad : MonoBehaviour
{
    public void BtnClc(string fileName)
    {
        var dialogues_day1 = Replica.LoadJson(fileName);
        Replica.ShowData(dialogues_day1);
    }
}
