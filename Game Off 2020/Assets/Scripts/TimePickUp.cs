using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimePickUp : MonoBehaviour
{

    public TimeController timeController;
    public GameObject mainCamera;

    public void Start()
    {
        timeController = mainCamera.GetComponent<TimeController>();
    }

    public void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            timeController.timeStart += 10;
            Destroy(gameObject);
        }
    }
}
