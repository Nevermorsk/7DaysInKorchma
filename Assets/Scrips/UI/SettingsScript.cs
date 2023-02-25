using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.Rendering;

public class SettingsScript : MonoBehaviour
{
    public Slider musicVolume;
    public Slider effectsVolume;
    public Slider dialogueVolume;
    public AudioMixerGroup musicMixer;
    public AudioMixerGroup effectsMixer;
    public AudioMixerGroup dilogueMixer;
    void Start()
    {
        Debug.Log($"{PlayerPrefs.GetFloat("musicVolume")} {PlayerPrefs.GetFloat("effectVolume")} {PlayerPrefs.GetFloat("dialogueVolume")}");
        musicVolume.value = PlayerPrefs.GetFloat("musicVolume");
        effectsVolume.value = PlayerPrefs.GetFloat("effectVolume");
        dialogueVolume.value = PlayerPrefs.GetFloat("dialogueVolume");
/*        effectsMixer.audioMixer.SetFloat("EffectsVolume", effectsVolume.value);
        musicMixer.audioMixer.SetFloat("MusicVolume", musicVolume.value);
        dilogueMixer.audioMixer.SetFloat("DialogueVolume", dialogueVolume.value);*/
    }
    public void exitClc()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void ChangeEffectsVolume(float volume)
    {
        PlayerPrefs.SetFloat("effectVolume", effectsVolume.value);
        effectsMixer.audioMixer.SetFloat("EffectsVolume", volume);
    }    
    public void ChangeMusicVolume(float volume)
    {
        PlayerPrefs.SetFloat("musicVolume", musicVolume.value);
        musicMixer.audioMixer.SetFloat("MusicVolume", volume);
    }    
    public void ChangeDialogueVolume(float volume)
    {
        PlayerPrefs.SetFloat("dialogueVolume", dialogueVolume.value);
        dilogueMixer.audioMixer.SetFloat("DialogueVolume", volume);
    }
}
