using System.Collections;
using UnityEngine;

public class Lava : MonoBehaviour
{

    public bool lavaActivation = false;
    public GameObject lavaPrefab; //The lava prefab from our "Prefabs" folder in unity

    void Start()
    {

    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.T)) //Used just for starting the lava rain
        {
            lavaActivation = true;
            StartCoroutine(LavaInstantiation());
        }
    }

    // The method for creating the lava rain
    public IEnumerator LavaInstantiation()
    {
        while (lavaActivation == true)
        {
            yield return new WaitForSeconds(Random.Range(0f, 10f));

            GameObject lavaDrop = Instantiate(lavaPrefab, transform.position, Quaternion.identity) as GameObject; // Instantiated as GameObject, just to be ok if we need anything else
        }
    }
}
