using System.Collections;
using UnityEngine;

public class Lava : MonoBehaviour
{

    public bool lavaActivation = false;
    public GameObject lavaPrefab; //The lava prefab from our "Prefabs" folder in unity
    public GameObject bigLavaPrefab;

    private void Awake()
    {
        StartCoroutine(StartLava());
    }

    void Start()
    {

    }


    public IEnumerator StartLava()
    {
        yield return new WaitForSeconds(20f);
        lavaActivation = true;
        StartCoroutine(LavaInstantiation());
        StartCoroutine(BigLava());
    }

    // The method for creating the lava rain
    public IEnumerator LavaInstantiation()
    {
        while (lavaActivation == true)
        {
            yield return new WaitForSeconds(Random.Range(0f, 10f));

            GameObject lavaDrop = Instantiate(lavaPrefab, transform.position, Quaternion.AngleAxis(90f, Vector3.forward)) as GameObject; // Instantiated as GameObject, just to be ok if we need anything else
        }
    }

    public IEnumerator BigLava()
    {
        while (lavaActivation == true)
        {
            yield return new WaitForSeconds(Random.Range(10f, 20f));

            GameObject bigLavaDrop = Instantiate(bigLavaPrefab, transform.position, Quaternion.AngleAxis(90f, Vector3.forward)) as GameObject;
        }
    }
}
