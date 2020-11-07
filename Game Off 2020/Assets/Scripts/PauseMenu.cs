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

    public void ActivatePauseMenu() //οταν ενεργοποιείται το μενού απενεργοποιούνται τα εξής
    {

        Time.timeScale = 0f;
        pauseMenu.SetActive(true);
        pauseMenu.transform.position = new Vector3(960, 540, 0); //Μετακινεί το pause menu στο κέντρο του canvas

    }

    public void DeactivatePauseMenu() //οταν απενεργοποιείται το μενού ενεργοποιούνται τα εξής
    {

        Time.timeScale = 1f;
        pauseMenu.SetActive(false);

        activatedMenu = false;
    }

    public void Exit()
    {
        SceneManager.LoadScene("Main Menu");
    }

}
