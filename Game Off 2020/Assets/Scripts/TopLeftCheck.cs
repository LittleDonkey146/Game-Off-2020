using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TopLeftCheck : MonoBehaviour
{

    public GameObject task;

    private void Start()
    {
        if (this.name ==  "1st object")
        {
            task = GameObject.Find("gearsfilled(Clone)");
        }
        if (this.name == "2nd object")
        {
            task = GameObject.Find("landinggearsfilled(Clone)");
        }
        if (this.name == "3rd object")
        {
            task = GameObject.Find("indicatorsfilled(Clone)");
        }
        if (this.name == "4th object")
        {
            task = GameObject.Find("screwdiverfilled(Clone)");
        }
        if (this.name == "5th object")
        {
            task = GameObject.Find("iconsfuefilled(Clone)");
        }
    }

    void LateUpdate()
    {
        if (task != null)
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
