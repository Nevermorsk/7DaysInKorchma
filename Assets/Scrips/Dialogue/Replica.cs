using UnityEngine;
using System.Collections.Generic;
using System;
using Newtonsoft.Json;

[Serializable]
public class Replica
{
    public string text;
    public string author;
    public string sprite;
    public string audio;
    public string action;
    public string order;
    public int moneyChange = 0;

    public static Queue<Replica> MakeQueue(string fileName)
    {
        string jsonTextFile = Resources.Load<TextAsset>($"dialogues/{fileName}").text;
        var data = JsonConvert.DeserializeObject< List<Replica> >(jsonTextFile);
        var dialogues = new Queue<Replica>(data);
        return dialogues;
    }    
    public static List<Replica> MakeList(string fileName)
    {
        string jsonTextFile = Resources.Load<TextAsset>($"dialogues/{fileName}").text;
        var data = JsonConvert.DeserializeObject< List<Replica> >(jsonTextFile);
        return data;
    }

    public static void ShowData(List<Replica> data) 
    {
        if (data != null)
        {
            foreach (var message in data)
            {
                if (message != null)
                {
                    Debug.Log($"Message ID: {message}");
                    Debug.Log($"Text: {message.text}");
                    Debug.Log($"Author: {message.author}");
                    Debug.Log($"Sprite: {message.sprite}");
                    Debug.Log($"Audio: {message.audio}");
                    Debug.Log($"Action: {message.action}");
                }
                else
                {
                    Debug.LogWarning($"Message ID {message} is null.");
                }
            }
        }
        else
        {
            Debug.LogWarning("Data or Messages is null.");
        }
        
    }    
    public static void ShowData(Queue<Replica> data) 
    {
        if (data != null)
        {
            foreach (var message in data)
            {
                if (message != null)
                {
                    Debug.Log($"Message ID: {message}");
                    Debug.Log($"Text: {message.text}");
                    Debug.Log($"Author: {message.author}");
                    Debug.Log($"Sprite: {message.sprite}");
                    Debug.Log($"Audio: {message.audio}");
                    Debug.Log($"Action: {message.action}");
                }
                else
                {
                    Debug.LogWarning($"Message ID {message} is null.");
                }
            }
        }
        else
        {
            Debug.LogWarning("Data or Messages is null.");
        }
        
    }
}
