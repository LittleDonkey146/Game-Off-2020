using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HumanMovement : MonoBehaviour
{

    public float speed = 3f;

    public TextMeshProUGUI text;

    private string peopleSavedCounter;

    public int peopleSaved;

    private void Start()
    {
        peopleSaved = 0;
    }

    void OnTriggerEnter2D(Collider2D collider) //NEEDS TO BE REWORKED, NOT WORKING AS IT SHOULD
    {
        if (collider.CompareTag("Human Goal")) 
        {
            peopleSaved += 1;
            peopleSavedCounter = peopleSaved.ToString();
            text.text = "People saved: " + peopleSavedCounter;
        }
    }
}
