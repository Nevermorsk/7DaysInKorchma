using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SettingsScript : MonoBehaviour
{
    public Button exit;

    void Start()
    {
        exit.onClick.AddListener(() => {
            SceneManager.LoadScene("MainMenu");
        });
    }
}
