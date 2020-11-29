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

    private PickingUp isPickedUp2;

    public TextMeshProUGUI text;

    public HumanManagement humansSaved;

    public Image image1, image2, image3, image4, image5;

    private void Start()
    {
        isPickedUp2 = FindObjectOfType<PickingUp>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        isPickedUp2.updateVariable();

        if (collision.CompareTag("FuelGameObject") || collision.CompareTag("MetalGameObject")) 
        {
            tasksDone += 1;
            tasksDoneCounter = tasksDone.ToString();
            text.text = "Tasks Done: " + tasksDoneCounter;
        }

        if(collision.CompareTag("Human Goal") && tasksDone == 5)
        {
            Destroy(image1);
            Destroy(image2);
            Destroy(image3);
            Destroy(image4);
            Destroy(image5);
        }
    }

    public void Update()
    {
        if (tasksDone == 5 && humansSaved.humanSaved == 5) 
        {
            SceneManager.LoadScene("Win Scene");
        }
    }

}
