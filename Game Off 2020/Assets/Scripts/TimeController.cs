using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeController : MonoBehaviour
{
    public float timeStart = 60;

    public Text textBox;

    void Update()
    {
        if (timeStart < 0)
        {
            SceneManager.LoadScene("Game Over Scene");
        }

        if (timeStart > 0)
        {
            timeStart -= Time.deltaTime;
            textBox.text = Mathf.Round(timeStart).ToString();
        }
    }
}
