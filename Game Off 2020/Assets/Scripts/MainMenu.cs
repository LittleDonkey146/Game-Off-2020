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
        StartCoroutine(WaitForTime());
    }

    public IEnumerator WaitForTime()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("Main Game");
    }

    //The options button is not yet ready

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
