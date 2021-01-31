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
    private GameObject collectScoreImageText;

    [SerializeField]
    private GameObject topRectangleImage, bottomRectangleImage;

    [SerializeField]
    private Text topRectangleText, bottomRectangleText;



    void Start()
    {
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
        topRectangleText.text= "(40+40)-25";
        bottomRectangleText.text = "(5+55)/2";
        
        Debug.Log("Start Game");
    }
}
