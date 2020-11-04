using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickingUp : MonoBehaviour
{
    //the value is 0.8, but it can change, based on the scale of our robot. Where it is now, it detects the pickup object, when it's close to our player
    public float sphereRadius = 0.8f;

    public Transform parent;

    public GameObject child;

    private void Update()
    {
        CheckForCollision();
    }

    private void CheckForCollision()
    {
        if(Physics.CheckSphere(transform.position, sphereRadius, LayerMask.GetMask("Pickup")))
        {
            if(Input.GetKey(KeyCode.F))
            {
                child.transform.SetParent(parent, true);
            }
        }
    }
}
