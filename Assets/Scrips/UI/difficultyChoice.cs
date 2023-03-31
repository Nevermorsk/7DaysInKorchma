using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Video;

public class difficultyChoice : MonoBehaviour
{
    [SerializeField] private VideoPlayer videoPlayer;
    void Start()
    {
        videoPlayer.url = Path.Combine(Application.streamingAssetsPath, $"difficultyBackground.mp4");
        videoPlayer.Prepare();
        videoPlayer.Play();
    }
    
    public void choiceDifficulty(int diff)
    {
        if (diff == 3)
        {
            transitionScipt.LoadScene("MainMenu", "ebat1");
        }
        else
        {
            DontDestroy.Diffuculty = diff;
            transitionScipt.LoadScene("Day 1", DontDestroy.startDay);
        }
    }
}
