using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{

    public AudioSource audioSource;

    private void Awake()
    {
        audioSource.Play();
    }

    public void BackButton()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
