using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lava : MonoBehaviour
{

    public GameObject lavaPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(LavaInstantiation());
    }

    // The method for creating the lava rain
    private IEnumerator LavaInstantiation()
    {
        GameObject lavaDrop = Instantiate(lavaPrefab, transform.position, Quaternion.identity) as GameObject; // Instantiated as GameObject, just to be ok if we need anything else
        yield return new WaitForSeconds(Random.Range(0, 10));
    }
}
