using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinLoseCheck : MonoBehaviour
{
    public float timeStart = 60;
    public float timeAdd = 10;
    private bool lostCheck = false;

    public Text textBox;
    public Text lostTextBox;
    public Text reclickBox;

    void Update()
    {
        if (timeStart < 0)
        {
            lostTextBox.text = "You Lost";
            lostCheck = true;
        }

        if (timeStart > 0 && lostCheck == false)
        {
            if (timeAdd > 0) 
            {
                timeAdd -= Time.deltaTime;
            }

            reclickBox.text = Mathf.Round(timeAdd).ToString();

            if (timeAdd < 0)
            {
                if (Input.GetKeyDown(KeyCode.K))
                {
                    timeStart += 30;
                    timeAdd = 10;
                }
            }

            timeStart -= Time.deltaTime;
            textBox.text = Mathf.Round(timeStart).ToString();
        }
    }
}
