﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void BackToTheMenu() 
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void PlayAgain() 
    {
        SceneManager.LoadScene("Main Game");
    }
    
}
