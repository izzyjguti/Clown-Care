using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine;


public class UILogic : MonoBehaviour
{
    public static int currentLevel = 1;
    public bool paused = false;
    public GameObject PauseMenu;
    public GameObject PauseButton;

    //level 1 icons
    public GameObject lungsIcon;
    public GameObject wigIcon;
    public GameObject intestinesIcon;

    //level 2 icons
    public GameObject teethIcon;
    public GameObject appendixIcon;
    public GameObject brainIcon;

    //scan icons
    public GameObject honkRateIcon;
    public GameObject waterPressureIcon;
    public GameObject melancholyIcon;

    public void Update()
    {
        LevelChange();
    }

    public void StartGame()
    {
       SceneManager.LoadSceneAsync("Intro");
    }

    public void StartLevel()
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

    }

    public void QuitToMenu()
    {
        SceneManager.LoadSceneAsync("Start");
    }

    public void LinkToManual()
    {
        Application.OpenURL("https://docs.google.com/document/d/1YWzMZ1MN0obeqviIon48yFX1O2DJqQxLSIFmgHyzrfQ/edit?usp=sharing");
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
        if(!paused)
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

    public void LevelChange()
    {
        if(SceneManager.GetActiveScene().name == "Level" && currentLevel == 1)
        {
            Debug.Log("level 1");
            Debug.Log(currentLevel);

            //in use
            lungsIcon.SetActive(true);
            wigIcon.SetActive(true);
            intestinesIcon.SetActive(true);
            honkRateIcon.SetActive(true);
            waterPressureIcon.SetActive(true);

            //not in use 
            teethIcon.SetActive(false);
            brainIcon.SetActive(false);
            appendixIcon.SetActive(false);
            melancholyIcon.SetActive(false);

        }
        else if(SceneManager.GetActiveScene().name == "Level" && currentLevel == 2)
        {
            Debug.Log("level 2");

            //in use 
            teethIcon.SetActive(true);
            brainIcon.SetActive(true);
            appendixIcon.SetActive(true);
            melancholyIcon.SetActive(true);
            honkRateIcon.SetActive(true);

            //not in use
            waterPressureIcon.SetActive(false);
            lungsIcon.SetActive(false);
            wigIcon.SetActive(false);
            intestinesIcon.SetActive(false);

        }
        else if(SceneManager.GetActiveScene().name == "Level" && currentLevel == 3)
        {
            Debug.Log("level 3");
            //remove appendix
            appendixIcon.SetActive(false);

            //in use
            lungsIcon.SetActive(true);
            wigIcon.SetActive(true);
            intestinesIcon.SetActive(true);
            teethIcon.SetActive(true);
            brainIcon.SetActive(true);
            waterPressureIcon.SetActive(true);
            honkRateIcon.SetActive(true);
            melancholyIcon.SetActive(true);

        }
        Debug.Log("end");
    }

    
}