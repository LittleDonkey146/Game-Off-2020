using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class TasksManager : MonoBehaviour
{
    public int tasksDone = 0;
    public string tasksDoneCounter;

    public HumanMovement peopleSaved;
    public int persons;

    private PickingUp isPickedUp2;

    public TextMeshProUGUI text;
    //public Text text;

    private void Start()
    {
        isPickedUp2 = FindObjectOfType<PickingUp>();
        peopleSaved = GameObject.FindGameObjectWithTag("People").GetComponent<HumanMovement>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        isPickedUp2.updateVariable();

        /*if (collision.CompareTag("FuelGameObject") || collision.CompareTag("MetalGameObject")) 
        {
            tasksDone += 1;
            tasksDoneCounter = tasksDone.ToString();
            text.text = "Tasks Done: " + tasksDoneCounter;
            //set the bool variable of "PickingUp" script to false (isPickedUp == false);
        }*/
    }

    public void Update()
    {
        persons = peopleSaved.peopleSaved;
        if (tasksDone == 5 && persons == 5) 
        {
            SceneManager.LoadScene("Win Scene");
        }
    }

}
