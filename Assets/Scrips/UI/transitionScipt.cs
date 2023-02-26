using System.Collections;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class transitionScipt : MonoBehaviour
{
    public static int dayNumber;
    public static string sceneName;
    public VideoPlayer vid;

    public static void LoadScene(string toSceneName, int toDayNumber)
    {
        dayNumber = toDayNumber;
        sceneName = toSceneName;
        SceneManager.LoadScene("LoadScene");
    }

    private void Start() {
        VideoClip clip = Resources.Load<VideoClip>($"video/day{dayNumber}.mp4") as VideoClip;
        vid.clip = clip;
        vid.Play();
        vid.loopPointReached += CheckOver;
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
