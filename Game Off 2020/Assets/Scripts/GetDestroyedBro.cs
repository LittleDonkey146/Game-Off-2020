using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetDestroyedBro : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(DestroyAtWill());
    }

    void Update()
    {

    }

    public IEnumerator DestroyAtWill()
    {
        yield return new WaitForSeconds(30f);
        Destroy(gameObject);
    }
}
