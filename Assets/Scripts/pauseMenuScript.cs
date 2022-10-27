using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class pauseMenuScript : MonoBehaviour
{
    public GameObject pauseMenu;
    public bool isPaused = false;
    void Start()
    {
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
    }
    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {

            TogglePauseGame();
        }
    }
    public void TogglePauseGame()
    {
        isPaused = !isPaused;
        pauseMenu.SetActive(isPaused);
        if (isPaused)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }
       

    }
    public void LoadLevel(string sceneName)
    {
        SceneManager.LoadScene(sceneName);


    }

}
