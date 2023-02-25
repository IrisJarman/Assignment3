using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Pause : MonoBehaviour
{

    public Button resumeButton;
    private bool isPaused = false;




    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }

    }
    void PauseGame()
    {
        Time.timeScale = 0;
        isPaused = true;
        resumeButton.gameObject.SetActive(true); 
    }
    public void ResumeGame() 
    {
        Time.timeScale = 1;
        isPaused = false;
        resumeButton.gameObject.SetActive(false);
    }
}