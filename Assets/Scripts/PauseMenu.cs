using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public static bool GameIsPaused = false;
    public GameObject player;
    public GameObject spawner;

    private void Start()
    {
        
        spawner.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (player == null)
        {
            Pause();
        }

    }


    public void Quit()
    {
        Application.Quit();
    }
    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("SampleScene");

    }
    void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        //Time.timeScale = 0f;
        GameIsPaused = true;
    }
    
}
