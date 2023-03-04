using System;
using System.Collections;
using System.IO;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class transitionScipt : MonoBehaviour
{
    public static int dayNumber;
    public static string sceneName;
    public VideoPlayer videoPlayer;
    public AudioSource backgroundMusic;

    public static void LoadScene(string toSceneName, int toDayNumber)
    {
        dayNumber = toDayNumber;
        sceneName = toSceneName;
        SceneManager.LoadScene("LoadScene");
    }

    private void Start()
    {
        AudioSource audioSource = gameObject.AddComponent<AudioSource>();
        AudioMixer audioMixer = Resources.Load<AudioMixer>("audio/mixer/main");
        AudioMixerGroup[] audioMixGroup = audioMixer.FindMatchingGroups("Master");
        audioSource.outputAudioMixerGroup = audioMixGroup[3];

        backgroundMusic = GameObject.FindGameObjectWithTag("music").GetComponent<AudioSource>();
        backgroundMusic.Pause();

        videoPlayer.Stop();

        videoPlayer.url = Path.Combine(Application.streamingAssetsPath, $"day{dayNumber}.mp4");
        videoPlayer.Prepare();

        audioSource.clip = Resources.Load($"audio/toVideo/day{dayNumber}") as AudioClip;
        audioSource.Play();

        videoPlayer.Play();
        videoPlayer.loopPointReached += CheckOver;
    }
    void CheckOver(UnityEngine.Video.VideoPlayer vp)
    {
        backgroundMusic.Play();
        StartCoroutine(LoadNextScene());
    }
    IEnumerator LoadNextScene()
    {
        AsyncOperation oper = SceneManager.LoadSceneAsync(sceneName);
        yield return null;
    }
}
