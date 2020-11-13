using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HumanMovement : MonoBehaviour
{

    public float speed = 3f;

    public GameObject[] waypoints;
    private int currentWP;

    Rigidbody2D rb2D;

    public Text text;
    private string peopleSavedCounter;

    public int peopleSaved;

    private void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        peopleSaved = 0;
    }

    private void Update()
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
        //Move(); PROPABLY NOT NEEDED
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        peopleSaved += 1;
        peopleSavedCounter = peopleSaved.ToString();
        text.text = peopleSavedCounter;
    }

    private void Move()
    {
        if (Vector2.Distance(gameObject.transform.position, waypoints[currentWP].transform.position) < 1) // Distance between the human and the waypoint.
        {
            currentWP += 1;
        }

        if (currentWP >= waypoints.Length)
        {
            currentWP = 0;
        }
        transform.LookAt(waypoints[currentWP].transform.position);

        transform.Translate(0, 0, speed * Time.deltaTime); // The movement is on z because LookAt works with the Z axis
    }
}
