using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuButtonsScript : MonoBehaviour
{
    public Button start;
    public Button exit;
    public Button settings;

    void Start()
    {
        start.onClick.AddListener(() => {
            SceneManager.LoadScene("Game");
        });
        exit.onClick.AddListener(() => {
            Application.Quit();        });
        settings.onClick.AddListener(() => {
            SceneManager.LoadScene("Settings");
        });
    }
}
