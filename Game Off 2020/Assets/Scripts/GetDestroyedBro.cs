using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetDestroyedBro : MonoBehaviour
{
    /*void Start()
    {
        StartCoroutine(DestroyAtWill());
    }

    void Update()
    {

    }*/

    private void OnTriggerExit2D(Collider2D collision)
    {
        Destroy(gameObject);
    }

    /*public IEnumerator DestroyAtWill()
    {
        yield return new WaitForSeconds(30f);
        Destroy(gameObject);
    }*/
}
