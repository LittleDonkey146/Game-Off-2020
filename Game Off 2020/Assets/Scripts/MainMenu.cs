using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    
    public void StartGame()
    {
        SceneManager.LoadScene("Main Game");
    }

    //The options button is not yet ready

    public void Exit()
    {
        Application.Quit();
    }
}
