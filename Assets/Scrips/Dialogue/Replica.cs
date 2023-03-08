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

    public static Dictionary<string, Replica> LoadJson(string fileName)
    {
        string jsonTextFile = Resources.Load<TextAsset>($"dialogues/{fileName}").text;
        Dictionary<string, Replica> data = JsonConvert.DeserializeObject<Dictionary<string, Replica>>(jsonTextFile);
        return data;
    }

    public static void ShowData(Dictionary<string, Replica> data) 
    {
        if (data != null)
        {
            foreach (var pair in data)
            {
                Replica message = data[pair.Key];
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
