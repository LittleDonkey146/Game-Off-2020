using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirCraftPartsManager : MonoBehaviour
{

    public AudioSource audioSource;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            StartCoroutine(WaitToPlay());
        }
    }

    IEnumerator WaitToPlay()
    {
        audioSource.Play();
        yield return new WaitForSeconds(0.1f);
        Destroy(gameObject);
    }
}
