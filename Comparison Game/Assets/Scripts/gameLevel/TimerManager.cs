using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TimerManager : MonoBehaviour
{
    private int remainingTime;
    bool isCountTheTime;


    [SerializeField]
    private Text timeText;

    GameManager gameManager;

    private void Awake()
    {
        gameManager = Object.FindObjectOfType<GameManager>();
    }


    void Start()
    {


        remainingTime = 10;
        isCountTheTime = true;




    }
    public void StartTime()
    {
        StartCoroutine(TimerRoutine());
    }

    IEnumerator TimerRoutine()
    {
        while (isCountTheTime)
        {

            yield return new WaitForSeconds(1f);
            if (remainingTime < 10)
            {
                timeText.text = "0" + remainingTime.ToString();
            }
            else
            {
                timeText.text = remainingTime.ToString();
            }
            if (remainingTime <= 0)
            {
                isCountTheTime = false;
                timeText.text = "";
                gameManager.GameOver();

            }
            remainingTime--;

        }

    }
}
