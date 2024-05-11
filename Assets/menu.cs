using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public string Title;
    public string gameOver;
    public void Play()
    {
        SceneManager.LoadScene(Title);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void Intro()
    {
        SceneManager.LoadScene(Title);
    }
    public void GameOver()
    {
        SceneManager.LoadScene(gameOver);
    }

}

