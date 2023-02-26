using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toSceneButtonScript : MonoBehaviour
{
    public int dayNumber;
    public string sceneName;
    public void toScene()
    {
        transitionScipt.LoadScene(sceneName, dayNumber);
    }
}
