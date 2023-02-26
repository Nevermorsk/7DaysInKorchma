using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour, IPointerDownHandler
{
    [SerializeField] private string _sceneName;

    public void OnPointerDown(PointerEventData eventData)
    {
        if (DialogueSystem.canNextDay)
        {
            DontDestroy.day++;
            DontDestroy.counter = 0;
            transitionScipt.LoadScene($"Window 1", DontDestroy.day);
            return;
        }
        SceneManager.LoadScene(_sceneName);
        DontDestroy.counter++;
    }
}
