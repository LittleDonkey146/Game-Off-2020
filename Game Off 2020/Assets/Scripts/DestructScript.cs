using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructScript : MonoBehaviour
{
    private Collider2D coll;
    public LayerMask layer;
    public Animator anim;
    public BoxCollider2D box;

    private void Start()
    {
        coll = GetComponent<Collider2D>();
    }

    private void Update()
    {
        if (coll.IsTouchingLayers(layer)) 
        {          
            StartCoroutine(Cont());
        }       
    }

    IEnumerator Cont() 
    {
        anim.SetBool("hitted", true);

        yield return new WaitForSeconds(1);
        
        box.isTrigger = true;

        Destroy(gameObject);

        yield return new WaitForSeconds(0.5f);

    }

}
