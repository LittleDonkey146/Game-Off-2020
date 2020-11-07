using System.Collections;
using UnityEngine;

public class Lava : MonoBehaviour
{

    public GameObject lavaPrefab;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LavaInstantiation());
    }

    // Update is called once per frame
    void Update()
    {
        //needs tweaking, to make it work and have the lava drops start with the T key, to test it.
    }

    // The method for creating the lava rain
    public IEnumerator LavaInstantiation()
    {

        GameObject lavaDrop = Instantiate(lavaPrefab, transform.position, Quaternion.identity) as GameObject; // Instantiated as GameObject, just to be ok if we need anything else
        yield return new WaitForSeconds(Random.Range(0f, 10f));

    }
}
