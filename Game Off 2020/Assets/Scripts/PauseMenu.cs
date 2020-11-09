using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public GameObject pauseMenu;

    public bool activatedMenu;

    private void Start()
    {
        pauseMenu.SetActive(false);
        activatedMenu = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P) && activatedMenu == false)
        {
            ActivatePauseMenu();
            activatedMenu = true;
        }
        else if (Input.GetKeyDown(KeyCode.P) && activatedMenu == true)
        {
            DeactivatePauseMenu();
        }
    }

    // When the Pause Menu is activated (when P is pressed)
    public void ActivatePauseMenu() 
    {

        Time.timeScale = 0f;
        pauseMenu.SetActive(true);
        pauseMenu.transform.position = new Vector3(960, 540, 0); // Moves the Pause Menu in the center of the canvas

    }

    // When the Pause Menu is deactivated (when P is pressed again)
    public void DeactivatePauseMenu() 
    {

        Time.timeScale = 1f;
        pauseMenu.SetActive(false);

        activatedMenu = false;
    }

    public void Exit()
    {
        SceneManager.LoadScene("Main Menu");
        Time.timeScale = 1f;
    }

}
