using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeController : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1f;

    public float timeStart = 60;

    public Text textBox;

    public void Update()
    {
        if (timeStart < 0)
        {
            SceneManager.LoadScene("Game Over Scene");
            //StartCoroutine(LoadLevel());
        }

        if (timeStart > 0)
        {
            timeStart -= Time.deltaTime;
            textBox.text = Mathf.Round(timeStart).ToString();
        }
    }

    /*IEnumerator LoadLevel() 
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene("Game Over Scene");
    }*/
}
