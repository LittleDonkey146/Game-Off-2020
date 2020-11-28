using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public Animator transition;
    public float waitFor = 2f;

    public void Update()
    {
        Scene scene = SceneManager.GetActiveScene();

        if (scene.name == "Main Game"
            || scene.name == "Credits"
            || scene.name == "Game Over Scene"
            || scene.name == "Main Menu"
            || scene.name == "Options"
            || scene.name == "Win Scene"
            || scene.name == "Tutorial Scene"
            || scene.name == "Test"){

            StartCoroutine(ChangeScene());
        }
    }

    IEnumerator ChangeScene() 
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(waitFor);
   
    }
}
