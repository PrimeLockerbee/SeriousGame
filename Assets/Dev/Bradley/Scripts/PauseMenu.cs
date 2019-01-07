using System;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    private void Start()
    {
        Time.timeScale = 1f;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
            TogglePause();
    }

    void TogglePause()
    {
        if (Time.timeScale == 0f)
        {
            Time.timeScale = 1f;
            print("UnPaused");
        }
        else
        {
            Time.timeScale = 0f;
            print("Paused");
        }
    }
}