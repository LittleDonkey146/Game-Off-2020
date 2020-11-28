using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{

    public AudioSource audioSource;
    public AudioClip homeScreen;
    public AudioClip clickSound;

    private void Awake()
    {
        audioSource.clip = homeScreen;
        audioSource.Play();
    }

    // The Start Game button
    public void StartGame() 
    {
        SceneManager.LoadScene("Tutorial Scene");
    }

    //The options button is not yet ready
    public void Options()
    {
        SceneManager.LoadScene("Options");
    }


    // Credits Button 
    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }

    // The Exit Game button
    public void Exit()
    {
        Application.Quit();
    }
}
