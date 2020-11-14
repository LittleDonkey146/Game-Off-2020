using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityScript : MonoBehaviour
{
    Rigidbody2D rb2D;

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
    }
}
