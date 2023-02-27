using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class testaudio : MonoBehaviour
{
    // Start is called before the first frame update

    void Start()
    {
        AudioSource audioSource = gameObject.AddComponent<AudioSource>();
        AudioMixer audioMixer = Resources.Load<AudioMixer>("audio/mixer/main");
        AudioMixerGroup[] audioMixGroup = audioMixer.FindMatchingGroups("Master");
        audioSource.outputAudioMixerGroup = audioMixGroup[3];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
