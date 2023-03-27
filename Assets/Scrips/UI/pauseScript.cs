using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class pauseScript : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public GameObject pauseSettingsUI;
    public static bool isPaused = false;

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
            string sceneName = SceneManager.GetActiveScene().name;
            Debug.Log(sceneName);
            if (isPaused)
            {
                Resume();
            }
           
            else if (sceneName != "MainMenu" && sceneName != "Settings" && sceneName != "difficultyChoice")
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

            GameObject[] obj = GameObject.FindGameObjectsWithTag("dayclip");
            obj[1].GetComponent<VideoPlayer>().Pause();
            obj[0].GetComponent<AudioSource>().Pause();

        isPaused = true;
    }

    void Resume()
    {
        Time.timeScale = 1f;
        pauseMenuUI.SetActive(false);
        pauseSettingsUI.SetActive(false);
        try
        {
            GameObject[] obj = GameObject.FindGameObjectsWithTag("dayclip");
            obj[1].GetComponent<VideoPlayer>().Play();
            obj[0].GetComponent<AudioSource>().Play();
        }
        catch { }
        isPaused = false;
    }
}
