using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DestroyAtWill());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator DestroyAtWill()
    {
        yield return new WaitForSeconds(30f);
        Destroy(gameObject);
    }
}
