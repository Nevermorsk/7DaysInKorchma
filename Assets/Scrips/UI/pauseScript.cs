using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseScript : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public GameObject pauseSettingsUI;
    private bool isPaused = false;

    private void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("pause");

        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
    }
    private void Start()
    {
        pauseMenuUI.SetActive(false);
        pauseSettingsUI.SetActive(false);
    }

    public void Continue () {
        Resume();
    }
    public void Settings () {
        pauseMenuUI.SetActive(false);
        pauseSettingsUI.SetActive(true);
    }
    public void Exit () {
        Resume();
        pauseMenuUI.SetActive(false);
        pauseSettingsUI.SetActive(false);
        SceneManager.LoadScene("MainMenu");
    }

    public void CloseSettings () {
        pauseMenuUI.SetActive(true);
        pauseSettingsUI.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log(SceneManager.GetActiveScene().name);
            if (isPaused)
            {
                Resume();
            }
            else if (SceneManager.GetActiveScene().name != "MainMenu")
            {
                Pause();
            }
        }
    }

    void Pause()
    {
        Time.timeScale = 0f;
        pauseMenuUI.SetActive(true);
        pauseSettingsUI.SetActive(false);
        isPaused = true;
    }

    void Resume()
    {
        Time.timeScale = 1f;
        pauseMenuUI.SetActive(false);
        pauseSettingsUI.SetActive(false);
        isPaused = false;
    }
}
