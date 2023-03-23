using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class StopVideo : MonoBehaviour
{
    [SerializeField] private VideoPlayer _video;
    // Start is called before the first frame update
    private bool stop;
    void Start()
    {
        stop = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(stop == false)
        {
            if (Input.GetKeyUp(KeyCode.Escape))
            {
                PauseGame();
            }
        }
        else {
            if(Input.GetKeyUp(KeyCode.Escape)){
                _video.Play();
                stop = false;
                            }
        }
    }
    public void PauseGame()
    {
        _video.Pause();
         stop = true;
    }
}
