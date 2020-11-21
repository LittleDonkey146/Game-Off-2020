using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TasksManager : MonoBehaviour
{
    public int tasksDone = 0;
    public string tasksDoneCounter;
    public Text text;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("TaskGameObject")) 
        {
            tasksDone += 1;
            tasksDoneCounter = tasksDone.ToString();
            text.text = tasksDoneCounter;
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
