using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Proffesor : MonoBehaviour
{
    public AudioSource audioSource;
    public Animator transition;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            StartCoroutine(StartGame());
        }
    }

    IEnumerator StartGame()
    {

        audioSource.Play(); //Play the audio

        transition.SetTrigger("10Passed"); //Start the transition

        yield return new WaitForSeconds(8f);

        SceneManager.LoadScene("Main Game");

    }
}
