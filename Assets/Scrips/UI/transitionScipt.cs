using System.Collections;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class transitionScipt : MonoBehaviour
{
    public static int dayNumber;
    public static string sceneName;
    public VideoPlayer videoPlayer;

    public static void LoadScene(string toSceneName, int toDayNumber)
    {
        dayNumber = toDayNumber;
        sceneName = toSceneName;
        SceneManager.LoadScene("LoadScene");
    }

    private void Start() {
        videoPlayer.Stop();
        videoPlayer.url = $"file://Assets/Resources/video/day{dayNumber}.mp4";
        videoPlayer.Play();
        videoPlayer.loopPointReached += CheckOver;
    }
    void CheckOver(UnityEngine.Video.VideoPlayer vp)
    {
        StartCoroutine(LoadNextScene());
    }
    IEnumerator LoadNextScene()
    {
        AsyncOperation oper = SceneManager.LoadSceneAsync(sceneName);
        yield return null;
    }
}
