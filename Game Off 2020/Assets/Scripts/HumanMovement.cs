using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HumanMovement : MonoBehaviour
{

    public float speed = 3f;

    //Rigidbody2D rb2D;

    public TextMeshProUGUI text;
    //public Text text;
    private string peopleSavedCounter;

    public int peopleSaved;

    private void Start()
    {
        //rb2D = GetComponent<Rigidbody2D>();
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
