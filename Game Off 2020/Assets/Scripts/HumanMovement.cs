using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HumanMovement : MonoBehaviour
{

    public float speed = 3f;

    //Rigidbody2D rb2D;

    public Text text;
    private string peopleSavedCounter;

    public int peopleSaved;

    private void Start()
    {
        //rb2D = GetComponent<Rigidbody2D>();
        peopleSaved = 0;
    }

    /*private void Update()
    {
        if (gameObject.transform.parent != null)
        {
            rb2D.velocity = new Vector2(0,0); //NEEDS IMPROVEMENT, WILL CHECK LATER
            rb2D.isKinematic = true;
        }
        else
        {
            rb2D.isKinematic = false;
        }
    }*/

    void OnTriggerEnter2D(Collider2D collider)
    {
        peopleSaved += 1;
        peopleSavedCounter = peopleSaved.ToString();
        text.text = peopleSavedCounter; 
    }
}
