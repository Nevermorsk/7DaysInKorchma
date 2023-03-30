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
        DontDestroy.Diffuculty = diff;
        transitionScipt.LoadScene("Window 1", 0);
    }
}
