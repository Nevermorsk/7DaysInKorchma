using UnityEngine;

public class toSceneButtonScript : MonoBehaviour
{
    public int dayNumber;
    public string sceneName;
    public void toScene()
    {
        AudioSource audio = gameObject.GetComponent<AudioSource>();
        audio.playOnAwake= false;
        audio.Stop(); 
        Debug.Log(audio.clip);
        Debug.Log(Resources.Load("audio/dialogue/gg/gg2", typeof(AudioClip)));
        /*audio.clip = AudioClip.Create("test", 12, 2, 1000, false);*/
        audio.clip = Resources.Load("audio/dialogue/gg/gg2") as AudioClip;
        Debug.Log(audio.clip); 
        audio.Play();
        /*transitionScipt.LoadScene(sceneName, dayNumber);*/
    }
}
