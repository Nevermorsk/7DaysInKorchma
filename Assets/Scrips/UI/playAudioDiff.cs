using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playAudioDiff : MonoBehaviour
{
    public void playAudioChain()
    {
        GetComponent<AudioSource>().Play();
    }
}
