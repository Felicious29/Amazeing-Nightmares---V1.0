using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange1 : MonoBehaviour {
    public void LoadGame()
    {
        SceneManager.LoadScene("Scene_01");
    }

    public void LoadHelp()
    {
        SceneManager.LoadScene("HowToMenu");
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void ClickExit()
    {
        Debug.Log("Game is exiting");
        Application.Quit();
    }
}