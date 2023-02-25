using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuButtonsScript : MonoBehaviour
{
    public AudioMixerGroup musicMixer;
    public AudioMixerGroup effectsMixer;
    public AudioMixerGroup dilogueMixer;

    void Start()
    {

    }
    public void StartClc()
    {
        SceneManager.LoadScene("Game");
    }    
    public void SettingsClc()
    {
        SceneManager.LoadScene("Settings");
    }    
    public void QuitClc()
    {
        Application.Quit();
    }

}
