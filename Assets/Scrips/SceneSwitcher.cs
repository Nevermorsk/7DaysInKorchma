using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void Switch(string _sceneName)
    {
        SceneManager.LoadScene(_sceneName);
    }
}
