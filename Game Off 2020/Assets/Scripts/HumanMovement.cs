using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanMovement : MonoBehaviour
{

    public float speed = 3f;

    public List<GameObject> waypoints;

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
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }

}
