using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuButtons : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadSceneAsync("Level");
    }
}
