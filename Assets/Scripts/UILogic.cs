using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine;


public class UILogic : MonoBehaviour
{
    public bool paused = false;
    public GameObject PauseMenu;
    public GameObject PauseButton;


    public void StartGame()
    {
       SceneManager.LoadSceneAsync("Intro");
    }

    public void StartLevel()
    {
        if (SceneManager.GetActiveScene().name == "Intro")
        {
            SceneManager.LoadSceneAsync("Level");
        }
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

    }

    public void QuitToMenu()
    {
        SceneManager.LoadSceneAsync("Start");
    }

    public void LinkToManual()
    {
        Application.OpenURL("https://youtu.be/dQw4w9WgXcQ?feature=shared");
    }

    public void QuitToDesktop()
    {
        Application.Quit();
    }

    public void WinGame()
    {
        SceneManager.LoadSceneAsync("WinScreen");
    }

    public void Pause()
    {
        if (!paused)
        {
            paused = true;
            Time.timeScale = 0;
            PauseMenu.SetActive(true);
            PauseButton.SetActive(false);
            Debug.Log(paused);

        }
        else if(paused)
        {
            paused = false;
            Time.timeScale = 1;
            PauseMenu.SetActive(false);
            PauseButton.SetActive(true);
            Debug.Log(paused);
        }
    }

    
}