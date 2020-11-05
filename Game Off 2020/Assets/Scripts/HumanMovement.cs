using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanMovement : MonoBehaviour
{

    public float speed = 3f;

    public GameObject[] waypoints;
    private int currentWP;

    Rigidbody2D rigidbody2D;

    private void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (gameObject.transform.parent != null)
        {
            rigidbody2D.velocity = new Vector2(0,0); //NEEDS IMPROVEMENT, WILL CHECK LATER
            rigidbody2D.isKinematic = true;
        }
        else
        {
            rigidbody2D.isKinematic = false;
        }

        Move();
    }

    private void Move()
    {
        if(Vector2.Distance(gameObject.transform.position, waypoints[currentWP].transform.position) < 1)
        {
            currentWP += 1;
        }

        if(currentWP >= waypoints.Length)
        {
            currentWP = 0;
        }
        transform.LookAt(waypoints[currentWP].transform.position);

        transform.Translate(0, 0, speed * Time.deltaTime);

        /*if (waypoints[currentWP].transform.position.x - gameObject.transform.position.x >= 0)
        {
            return;
        }
        else
        {
            transform.rotation = Quaternion.AngleAxis(180, Vector3.up);
        }*/
    }

}
