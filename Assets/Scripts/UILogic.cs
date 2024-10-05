using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine;


public class UILogic : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadSceneAsync("Level");
    }

    public void Settings()
    {
        SceneManager.LoadSceneAsync("Settings");
    }

    public void AudioSlider()
    {

    }

    public void MuteAudio()
    {

    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void BackButton()
    {
        if (SceneManager.GetActiveScene().name == "Settings")
        {
            SceneManager.LoadSceneAsync("Start");
        }
        if (SceneManager.GetActiveScene().name == "Settings")
        {
            SceneManager.LoadSceneAsync("Start");
        }

    }

    public void QuitToMenu()
    {
        SceneManager.LoadSceneAsync("Start");
    }

    public void PauseGame()
    {

    }
}