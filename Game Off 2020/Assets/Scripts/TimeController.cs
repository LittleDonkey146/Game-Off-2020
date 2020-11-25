using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class TimeController : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1f;

    public float timeStart = 60;

    public TextMeshProUGUI textBox;

    public void Update()
    {
        if (timeStart < 0)
        {
            SceneManager.LoadScene("Game Over Scene");
        }

        if (timeStart > 0)
        {
            timeStart -= Time.deltaTime;
            textBox.text = "Time Left " + Mathf.Round(timeStart).ToString();
        }
    }
}
