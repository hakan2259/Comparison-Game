using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
    [SerializeField]
    private GameObject pausePanel;

    GameManager gameManager;

    
    private void OnEnable()
    {
        gameManager = Object.FindObjectOfType<GameManager>();
        Time.timeScale = 0f;
        gameManager.stopCountDownSound();
        


    }
    private void OnDisable()
    {
        Time.timeScale = 1f;
    }

    public void StartAgain()
    {
        pausePanel.SetActive(false);
        gameManager.playCountDownSound();

    }

    public void BackToTheMenu()
    {
        SceneManager.LoadScene("MenuLevel");

    }
    public void QuitGame()
    {
        Application.Quit();

    }
}
