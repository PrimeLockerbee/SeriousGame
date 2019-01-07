using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagers : MonoBehaviour
{
    public void LoadOnClick(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }

    public void QuitOnClick()
    {
        Application.Quit();
    }
}
