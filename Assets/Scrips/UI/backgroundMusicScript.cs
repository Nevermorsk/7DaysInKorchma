using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class backgroundMusicScript : MonoBehaviour
{
    [SerializeField] private AudioClip forest;
    [SerializeField] private AudioClip tawern;
    [SerializeField] private AudioMixerGroup musicMixer;
    [SerializeField] private AudioMixerGroup effectsMixer;
    [SerializeField] private AudioMixerGroup dilogueMixer;
    void Awake()
    {
        Debug.Log($"{PlayerPrefs.GetFloat("musicVolume")} {PlayerPrefs.GetFloat("effectVolume")} {PlayerPrefs.GetFloat("dialogueVolume")}");
        GameObject[] objs = GameObject.FindGameObjectsWithTag("music");

        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
    }
    void Start()
    {
        effectsMixer.audioMixer.SetFloat("EffectsVolume", PlayerPrefs.GetFloat("effectVolume"));
        musicMixer.audioMixer.SetFloat("MusicVolume", PlayerPrefs.GetFloat("musicVolume"));
        dilogueMixer.audioMixer.SetFloat("DialogueVolume", PlayerPrefs.GetFloat("dialogueVolume"));
    }

    private void FixedUpdate()
    {
        string sceneName = SceneManager.GetActiveScene().name;
        if ((sceneName == "MainMenu" || sceneName == "difficultyChoice" || sceneName == "Settings") && GetComponent<AudioSource>().clip.name != "tawern")
        {
            GetComponent<AudioSource>().clip = tawern;
            GetComponent<AudioSource>().Play();
        }
        else if ((sceneName == "Day 1" || sceneName == "Window 1") && GetComponent<AudioSource>().clip.name != "forest")
        {
            GetComponent<AudioSource>().clip = forest;
            GetComponent<AudioSource>().Play();
        }
        
    }

}
