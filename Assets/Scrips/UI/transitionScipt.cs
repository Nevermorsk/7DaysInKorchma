using System.Collections;
using System.IO;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class transitionScipt : MonoBehaviour
{   
    public static int dayNumber;
    public static string sceneName;
    public static string videoName;

    public bool skipScene = false;
    public VideoPlayer videoPlayer;
    private AudioSource backgroundMusic;

    public static void LoadScene(string toSceneName, string loadVideoName)
    {
        dayNumber = -1;
        videoName = loadVideoName;
        sceneName = toSceneName;
        SceneManager.LoadScene("LoadScene");
    }    
    public static void LoadScene(string toSceneName, int toDayNumber)
    {
        dayNumber = toDayNumber;
        videoName = null;
        sceneName = toSceneName;
        SceneManager.LoadScene("LoadScene");
    }

    private void Start()
    {
        AudioSource audioSource = gameObject.AddComponent<AudioSource>();
        AudioMixer audioMixer = Resources.Load<AudioMixer>("audio/mixer/main");
        AudioMixerGroup[] audioMixGroup = audioMixer.FindMatchingGroups("Master");
        audioSource.outputAudioMixerGroup = audioMixGroup[3];

        try {
            backgroundMusic = GameObject.FindGameObjectWithTag("music").GetComponent<AudioSource>();
            backgroundMusic.Pause();
        } catch { }

        videoPlayer.Stop();
        if (videoName != null)
        {
            videoPlayer.url = Path.Combine(Application.streamingAssetsPath, $"{videoName}.mp4");
            videoPlayer.Prepare();
            audioSource.clip = Resources.Load($"audio/toVideo/day{videoName}") as AudioClip;
        }
        else
        {
            videoPlayer.url = Path.Combine(Application.streamingAssetsPath, $"day{dayNumber}.mp4");
            videoPlayer.Prepare();
            audioSource.clip = Resources.Load($"audio/toVideo/day{dayNumber}") as AudioClip;
            
        }
        audioSource.Play();
        videoPlayer.Play();

        if (skipScene)
        {
            try { backgroundMusic.Play(); } catch { }
            StartCoroutine(LoadNextScene());
        }
        else
        {
            videoPlayer.loopPointReached += CheckOver;
        }
        }
    void CheckOver(UnityEngine.Video.VideoPlayer vp)
    {
        try { backgroundMusic.Play(); } catch { }
        StartCoroutine(LoadNextScene());
    }
    IEnumerator LoadNextScene()
    {
        AsyncOperation oper = SceneManager.LoadSceneAsync(sceneName);
        yield return null;
    }
}
