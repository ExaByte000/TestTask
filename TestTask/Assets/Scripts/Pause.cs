using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject Menu;
    public GameObject OptionsMenu;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseGame();
        }
        
    }
    private void PauseGame()
    {
        Menu.SetActive(true);
        Time.timeScale = 0f;
    }
    public void ResumeGame()
    {
        Menu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Options()
    {
        Menu.SetActive(false);
        OptionsMenu.SetActive(true);
    }

    public void BackButton()
    {
        Menu.SetActive(true);
        OptionsMenu.SetActive(false);
    }

    public void Exit()
    {
        Application.Quit();
    }

}
