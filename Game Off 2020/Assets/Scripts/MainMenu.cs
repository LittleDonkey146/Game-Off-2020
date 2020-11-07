using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    
    // The Start Game button
    public void StartGame() 
    {
        SceneManager.LoadScene("Main Game");
    }

    //The options button is not yet ready

    // The Exit Game button
    public void Exit()
    {
        Application.Quit();
    }
}
