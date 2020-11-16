using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityScript : MonoBehaviour
{
    Rigidbody2D rb2D;
    public PickingUp isPickedUp2;

    private void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (gameObject.transform.parent != null)
        {
            rb2D.isKinematic = true;
        }
        else
        {
            rb2D.isKinematic = false;   
        }
        //transform.position = new Vector3(transform.position.x, transform.position.y, 0f);
        //gameObject.transform.rotation = Quaternion.identity;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.transform.parent != null) 
        {
            Destroy(gameObject);
            isPickedUp2.isPickedUp = false;
            //set the bool variable of "PickingUp" script to false (isPickedUp == false);
        }
    }
}
