using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResultManager : MonoBehaviour
{
    [SerializeField]
    private Text correctNumberText, wrongNumberText, totalScoreText;

    int scoreTime = 10;
    bool isScoreTime = true;
    int totalScore, writingScore, scoreIncrease;


    private void Awake()
    {
        isScoreTime = true;

    }

    public void ShowResults(int correctNumber, int wrongNumber, int score)
    {

        correctNumberText.text = correctNumber.ToString();
        wrongNumberText.text = wrongNumber.ToString();
        totalScoreText.text = score.ToString();

        totalScore = score;
        scoreIncrease = totalScore / 10;

        StartCoroutine(WriteScoreRoutine());





    }
    IEnumerator WriteScoreRoutine()
    {

        while (isScoreTime)
        {

            yield return new WaitForSeconds(0.1f);
            writingScore += scoreIncrease;
            if (writingScore >= totalScore)
            {
                writingScore = totalScore;
            }

            totalScoreText.text = writingScore.ToString();

            if (scoreTime <= 0)
            {
                isScoreTime = false;
            }

            scoreTime--;

        }

    }

    public void StartAgain()
    {
        SceneManager.LoadScene("GameLevel");
    }
    public void BackMenu()
    {
        SceneManager.LoadScene("MenuLevel");
    }

}
