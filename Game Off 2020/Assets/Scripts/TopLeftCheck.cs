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
            //NEEDS TO BE DONE BY TOMORROW
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

    IEnumerator CheckIfAlive()
    {
        yield return new WaitForSeconds(1f);

        if (task.gameObject.activeSelf == true)
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
