using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GameObject scoreTimePanel;

    [SerializeField]
    private GameObject collectScoreImageText, chooseTheBigNumberText;

    [SerializeField]
    private GameObject topRectangleImage, bottomRectangleImage;

    [SerializeField]
    private Text topRectangleText, bottomRectangleText;

    [SerializeField]
    private GameObject darkGreenCircles, lightGreenCircles;


    TimerManager timerManager;

    CirclesManager circlesManager;

    int gameCount, whichGame, topValue, bottomValue, bigValue;

    int buttonValue;



    private void Awake()
    {
        timerManager = Object.FindObjectOfType<TimerManager>();
        circlesManager = Object.FindObjectOfType<CirclesManager>();


    }


    void Start()
    {

        darkGreenCircles.GetComponent<CanvasGroup>().DOFade(1, 1f);
        lightGreenCircles.GetComponent<CanvasGroup>().DOFade(1, 1f);
        topRectangleText.text = "";
        bottomRectangleText.text = "";

        updateSceneScreen();
    }

    void updateSceneScreen()
    {

        scoreTimePanel.GetComponent<CanvasGroup>().DOFade(1, 1f);
        collectScoreImageText.GetComponent<CanvasGroup>().DOFade(1, 1f);


        topRectangleImage.transform.GetComponent<RectTransform>().DOLocalMoveX(0, 0.7f);
        bottomRectangleImage.transform.GetComponent<RectTransform>().DOLocalMoveX(0, 0.7f);


    }

    public void StartGame()
    {
        timerManager.StartTime();
        WhichGame();
        collectScoreImageText.GetComponent<CanvasGroup>().DOFade(0, 0.2f);
        chooseTheBigNumberText.GetComponent<CanvasGroup>().DOFade(1, 0.2f);




    }
    void WhichGame()
    {

        if (gameCount < 5)
        {
            whichGame = 1;
        }
        else if (gameCount >= 5 && gameCount < 10)
        {
            whichGame = 2;
        }
        else if (gameCount >= 10 && gameCount < 15)
        {
            whichGame = 3;
        }
        else if (gameCount >= 15 && gameCount < 20)
        {
            whichGame = 4;
        }
        else if (gameCount >= 20 && gameCount < 25)
        {
            whichGame = 5;
        }
        switch (whichGame)
        {
            case 1:
                FirstFunction();
                break;
            case 2:
                SecondFunction();
                break;
            case 3:
                ThirdFunction();
                break;
            case 4:
                FourthFunction();
                break;
            case 5:
                FifthFunction();
                break;
        }
    }
    void FirstFunction()
    {

        int randomValue = Random.Range(0, 50);
        if (randomValue <= 25)
        {
            topValue = Random.Range(2, 50);
            bottomValue = topValue + Random.Range(1, 10);
        }
        else
        {
            topValue = Random.Range(2, 50);
            bottomValue = topValue - Random.Range(1, 10);

        }

        if (topValue > bottomValue)
        {
            bigValue = topValue;
        }
        else
        {
            bigValue = bottomValue;
        }

        topRectangleText.text = topValue.ToString();
        bottomRectangleText.text = bottomValue.ToString();

    }

    void SecondFunction()
    {
        int number1 = Random.Range(1, 10);
        int number2 = Random.Range(1, 20);
        int number3 = Random.Range(1, 10);
        int number4 = Random.Range(1, 20);

        topValue = number1 + number2;
        bottomValue = number3 + number4;

        if (topValue > bottomValue)
        {
            bigValue = topValue;
        }
        else if (bottomValue > topValue)
        {
            bigValue = bottomValue;
        }
        else if (topValue == bottomValue)
        {
            SecondFunction();
            return;
        }
        topRectangleText.text = number1 + " + " + number2;
        bottomRectangleText.text = number3 + " + " + number4;

    }


    void ThirdFunction()
    {
        int number1 = Random.Range(11, 33);
        int number2 = Random.Range(1, 11);
        int number3 = Random.Range(11, 33);
        int number4 = Random.Range(1, 11);

        topValue = number1 - number2;
        bottomValue = number3 - number4;

        if (topValue > bottomValue)
        {
            bigValue = topValue;
        }
        else if (bottomValue > topValue)
        {
            bigValue = bottomValue;
        }
        else if (topValue == bottomValue)
        {
            ThirdFunction();
            return;
        }
        topRectangleText.text = number1 + " - " + number2;
        bottomRectangleText.text = number3 + " - " + number4;
    }

    void FourthFunction()
    {
        int number1 = Random.Range(1, 11);
        int number2 = Random.Range(1, 11);
        int number3 = Random.Range(1, 11);
        int number4 = Random.Range(1, 11);

        topValue = number1 * number2;
        bottomValue = number3 * number4;

        if (topValue > bottomValue)
        {
            bigValue = topValue;
        }
        else if (bottomValue > topValue)
        {
            bigValue = bottomValue;
        }
        else if (topValue == bottomValue)
        {
            FourthFunction();
            return;
        }
        topRectangleText.text = number1 + " X " + number2;
        bottomRectangleText.text = number3 + " X " + number4;
    }

    void FifthFunction()
    {

        int divisor1 = Random.Range(2, 10);
        topValue = Random.Range(2, 10);
        int dividend1 = divisor1 * topValue;

        int divisor2 = Random.Range(2, 10);
        bottomValue = Random.Range(2, 10);
        int dividend2 = bottomValue * divisor2;

        if(topValue>bottomValue){
            bigValue=topValue;
        }else if(bottomValue>topValue){
            bigValue = bottomValue;
        }
        else if(topValue == bottomValue){
            FifthFunction();
            return;
        }
        topRectangleText.text = dividend1 + " / " + divisor1;
        bottomRectangleText.text = dividend2 + " / " + divisor2;



    }
    public void setButtonValue(string buttonName)
    {
        if (buttonName == "topButton")
        {
            buttonValue = topValue;
        }
        else if (buttonName == "bottomButton")
        {
            buttonValue = bottomValue;
        }

        if (bigValue == buttonValue)
        {
            circlesManager.turnOnCirclesScale(gameCount % 5);
            gameCount++;
            WhichGame();
        }
        else
        {
            Debug.Log("Wrong!!!");

        }

    }


}
