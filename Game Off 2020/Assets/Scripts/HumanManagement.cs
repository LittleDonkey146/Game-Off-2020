using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HumanManagement : MonoBehaviour
{

    public int humanSaved = 0;
    private string humanSavedCounter;

    public TextMeshProUGUI text;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.CompareTag("People"))
        {
            humanSaved++;
            humanSavedCounter = humanSaved.ToString();
            text.text = "People Saved: " + humanSavedCounter;
        }
    }
}
