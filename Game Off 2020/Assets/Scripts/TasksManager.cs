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

    public TextMeshProUGUI text;
    //public Text text;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("TaskGameObject")) 
        {
            tasksDone += 1;
            tasksDoneCounter = tasksDone.ToString();
            text.text = "Tasks Done: " + tasksDoneCounter;
        }
    }

    public void Update()
    {
        if (tasksDone == 4) 
        {
            SceneManager.LoadScene("Win Scene");
        }
    }

}
