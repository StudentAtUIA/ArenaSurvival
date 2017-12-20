using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InGameMenu : MonoBehaviour {

    public Canvas gameMenu;
    private bool escPressed = false;

    void Start()
    {
        gameMenu.enabled = false; 
    }

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Escape) && escPressed == false)
        {
            gameMenu.enabled = true;
            escPressed = true;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && escPressed == true)
        {
            gameMenu.enabled = false;
            escPressed = false;
        }
    }


    public void QuitGame()
    {
        Application.Quit();
    }

}
