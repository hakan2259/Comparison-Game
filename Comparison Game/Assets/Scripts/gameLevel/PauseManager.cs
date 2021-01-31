using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
    [SerializeField]
    private GameObject pausePanel;
    private void OnEnable()
    {
        Time.timeScale = 0f;

    }

    private void OnDisable()
    {
        Time.timeScale = 1f;
    }

    public void StartAgain()
    {
        pausePanel.SetActive(false);

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
