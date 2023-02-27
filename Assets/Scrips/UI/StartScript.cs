using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class StartScript : MonoBehaviour
{
    public string videoName;
    public VideoPlayer videoPlayer;
    // Start is called before the first frame update
    void Start()
    {
        videoPlayer.Stop();
        videoPlayer.url = $"https://niceefoxy.ml/{videoName}.mp4";
        videoPlayer.Prepare();
        videoPlayer.Play();
        videoPlayer.loopPointReached += CheckOver;
    }
    void CheckOver(UnityEngine.Video.VideoPlayer vp)
    {
        StartCoroutine(LoadNextScene());
    }
    IEnumerator LoadNextScene()
    {
        AsyncOperation oper = SceneManager.LoadSceneAsync("MainMenu");
        yield return null;
    }
}

