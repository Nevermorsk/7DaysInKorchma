using UnityEngine;
using UnityEngine.Audio;

public class backgroundMusicScript : MonoBehaviour
{
    [SerializeField] AudioMixerGroup musicMixer;
    [SerializeField] AudioMixerGroup effectsMixer;
    [SerializeField] AudioMixerGroup dilogueMixer;
    void Awake()
    {
        Debug.Log($"{PlayerPrefs.GetFloat("musicVolume")} {PlayerPrefs.GetFloat("effectVolume")} {PlayerPrefs.GetFloat("dialogueVolume")}");
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Speaker");

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

}
