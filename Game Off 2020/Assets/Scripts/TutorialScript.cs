using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialScript : MonoBehaviour
{
    public Animator transition;
    public AudioSource audioSource;
    public bool isPlaying;

    private void Start()
    {
        Scene scene = SceneManager.GetActiveScene();

        if (scene.name == "Tutorial Scene")
        {
            StartCoroutine(WaitBeforeTheGame());          
        }
        
    }

    IEnumerator WaitBeforeTheGame()
    { 
        yield return new WaitForSeconds(15f); //Wait dor 10 sec

        audioSource.Play(); //Play the audio

        transition.SetTrigger("10Passed"); //Start the transition

        yield return new WaitForSeconds(8f);

        SceneManager.LoadScene("Main Game");

    }

}
