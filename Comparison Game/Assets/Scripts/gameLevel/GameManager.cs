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
        switch (whichGame)
        {
            case 1:
                FirstFunction();
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
        
        if(bigValue == buttonValue){
            circlesManager.turnOnCirclesScale(gameCount%5);
            gameCount++;
            Debug.Log(gameCount%5);

        }else{
            Debug.Log("Wrong!!!");

        }

    }


}
