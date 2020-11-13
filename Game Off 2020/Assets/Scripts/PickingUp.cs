using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickingUp : MonoBehaviour
{
    //the value is 0.8, but it can change, based on the scale of our robot. Where it is now, it detects the pickup object, when it's close to our player
    private float minDepth = -2f;
    private float maxDepth = 2f;
    private float sphereRadius = 0.8f;

    public Transform parent;

    public GameObject child;

    private void Update()
    {
        CheckForCollision();
    }

    private void CheckForCollision()
    {
        if(Physics2D.OverlapCircle(transform.position, sphereRadius, LayerMask.GetMask("Pickup"), minDepth, maxDepth))
        {
            if(Input.GetKey(KeyCode.F))
            {
                child.transform.SetParent(parent, true); //NEEDS REVIEW LATER
            }
            else if (Input.GetKey(KeyCode.G))
            {
                child.transform.SetParent(null);
            }
        }
    }
    

    /*
    public Transform grabDetect;
    public Transform boxHolder;
    public float arrayDist;

    public Rigidbody2D rigidBoadyCol;

    void Update()
    {
        RaycastHit2D grabCheckRight = Physics2D.Raycast(grabDetect.position, Vector2.right * transform.localScale, arrayDist);
        RaycastHit2D grabCheckLeft = Physics2D.Raycast(grabDetect.position, Vector2.left * transform.localScale, arrayDist);


        if (grabCheckRight.collider != null && grabCheckRight.collider.tag == "Box")
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                rigidBoadyCol.isKinematic = true;
                rigidBoadyCol.velocity = new Vector2(0, 0);
                grabCheckRight.collider.gameObject.transform.parent = boxHolder;
                grabCheckRight.collider.gameObject.transform.position = boxHolder.position;

            }
            else
            {
                if (Input.GetKeyDown(KeyCode.G))
                {
                    rigidBoadyCol.isKinematic = false;
                    grabCheckRight.collider.gameObject.transform.parent = null;
                }
            }

        }

        if (grabCheckLeft.collider != null && grabCheckLeft.collider.tag == "Box")
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                rigidBoadyCol.isKinematic = true;
                rigidBoadyCol.velocity = new Vector2(0, 0);
                grabCheckLeft.collider.gameObject.transform.parent = boxHolder;
                grabCheckLeft.collider.gameObject.transform.position = boxHolder.position;

            }
            else
            {
                if (Input.GetKeyDown(KeyCode.G))
                {
                    rigidBoadyCol.isKinematic = false;
                    grabCheckLeft.collider.gameObject.transform.parent = null;
                }
            }

        }
    }*/
}
