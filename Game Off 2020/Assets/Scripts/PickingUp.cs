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
}
