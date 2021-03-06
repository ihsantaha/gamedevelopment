﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    int currentSceneIndex;

    void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
    }

    public void LoadNextScene()
    {    
        SceneManager.LoadSceneAsync(currentSceneIndex + 1);
    }

    public void LoadPreviousScene()
    {
        SceneManager.LoadSceneAsync(currentSceneIndex - 1);
    }

    public void LoadSpecificScene(int buildIndex)
    {
        SceneManager.LoadScene(buildIndex);
    }

    public void CloseMenu()
    {
        SceneManager.LoadSceneAsync(StaticClass.CurrentScene);
    }

    public void Quit()
    {
        Application.Quit();
    }

    // All Scene Transitions Determined by Exit Number
    public void NavigateFrom(int exitNumber)
    {
        if (exitNumber == 3)
        {
            SceneManager.LoadSceneAsync(StaticClass.PreviousScene);
            StaticClass.PreviousScene = 3;
        }
        if (exitNumber == 2)
            SceneManager.LoadSceneAsync(4);
        if (exitNumber == 1)
            SceneManager.LoadSceneAsync(5);
    }
}
