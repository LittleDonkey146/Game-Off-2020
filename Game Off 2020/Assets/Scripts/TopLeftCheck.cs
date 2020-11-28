using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TopLeftCheck : MonoBehaviour
{

    public GameObject task;

    void Update()
    {
        if(task != null)
        {
            gameObject.SetActive(true);
            Debug.Log("AEK0");
        }
        else
        {
            gameObject.SetActive(false);
            Debug.Log("aek1");
        }
    }
}
