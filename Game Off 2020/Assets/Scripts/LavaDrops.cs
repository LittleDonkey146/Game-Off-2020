using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaDrops : MonoBehaviour
{

    public float damage = 30f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == 8 || collision.gameObject.layer == 9) //Layer 8 is the ground.
        {
            Destroy(gameObject);
        }
    }

}
