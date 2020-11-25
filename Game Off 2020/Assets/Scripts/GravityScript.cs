using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityScript : MonoBehaviour
{
    Rigidbody2D rb2D;
    private PickingUp isPickedUp2;

    private void Awake()
    {
        isPickedUp2 = FindObjectOfType<PickingUp>();
    }

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
        if (collision.CompareTag("Human Goal")) 
        {
            Destroy(gameObject);
        } 

        if (gameObject.transform.parent != null) 
        {
            isPickedUp2.updateVariable();
            //set the bool variable of "PickingUp" script to false (isPickedUp == false);
        }
    }
}
