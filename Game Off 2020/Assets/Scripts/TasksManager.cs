using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TasksManager : MonoBehaviour
{
    public int tasksDone = 0;
    public string tasksDoneCounter;
    public Text text;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        tasksDone += 1;
        tasksDoneCounter = tasksDone.ToString();
        text.text = tasksDoneCounter;
    }
}
