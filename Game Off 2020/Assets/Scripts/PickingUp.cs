using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickingUp : MonoBehaviour
{
    public Transform grabDetect;
    public Transform boxHolder;

    public bool isPickedUp = false;

    public float sphereRadius;
    public float minDepth;
    public float maxDepth;

    void Update()
    {

        PickUpMethod();
        
    }

    private void PickUpMethod()
    {
        Collider2D collider = Physics2D.OverlapCircle(transform.position, sphereRadius, LayerMask.GetMask("Prefabs"), minDepth, maxDepth);

        if (isPickedUp == true && Input.GetKeyDown(KeyCode.G))
        {
            boxHolder.GetChild(0).transform.SetParent(null);
            isPickedUp = false;
        }

        if (collider == null)
        {

            return;

        }
        else if (collider.tag == "Box")
        {
            if(Input.GetKeyDown(KeyCode.F))
            {
                if (isPickedUp == false)
                {
                    collider.transform.parent = boxHolder;
                    collider.transform.position = boxHolder.position;
                    isPickedUp = true;
                }
                
            }
            
        }
        
    }
}
