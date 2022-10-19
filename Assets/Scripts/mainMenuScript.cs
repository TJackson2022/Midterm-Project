using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class mainMenuScript : MonoBehaviour
{

    public void ExitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    // Update is called once per frame
    public void LoadLevel(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}