using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickingUp : MonoBehaviour
{
    public Transform grabDetect;
    public Transform boxHolder;

    public bool isPickedUp = false;

    public float sphereRadius;
    public float minDepth;
    public float maxDepth;

    public AudioSource audioSource;
    public AudioClip fuelAudio;
    public AudioClip metalAudio;
    public AudioClip peopleAudio;

    void Update()
    {
        PickUpMethod();        
    }

    private void PickUpMethod()
    {
        Collider2D collider = Physics2D.OverlapCircle(transform.position, sphereRadius, LayerMask.GetMask("Prefabs"), minDepth, maxDepth);

        if (isPickedUp == true && Input.GetKeyDown(KeyCode.G))
        {
            boxHolder.GetChild(0).transform.SetParent(null);
            isPickedUp = false;
        }

        if (collider == null)
        {
            return;
        }
        else if (collider.tag == "People" || collider.tag == "FuelGameObject" || collider.tag == "MetalGameObject")
        {
            if(Input.GetKeyDown(KeyCode.F))
            {
                if (collider.tag == "FuelGameObject" && isPickedUp == false)
                {
                    audioSource.clip = fuelAudio;
                    audioSource.Play();
                    audioSource.loop = false;
                }

                if (collider.tag == "MetalGameObject" && isPickedUp == false)
                {
                    audioSource.clip = metalAudio;
                    audioSource.Play();
                    audioSource.loop = false;
                }

                if (collider.tag == "People" && isPickedUp == false)
                {
                    audioSource.clip = peopleAudio;
                    audioSource.Play();
                    audioSource.loop = false;
                }

                if (isPickedUp == false)
                {
                    collider.transform.parent = boxHolder;
                    collider.transform.position = boxHolder.position;
                    isPickedUp = true;
                }
                
            }
            
        }
        
    }

    public void updateVariable() 
    {
        isPickedUp = false;
    }
}
