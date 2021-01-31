using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;
public class MenuManager : MonoBehaviour
{
    [SerializeField]
    private Transform brain;

    [SerializeField]
    private Transform startButton;

    void Start()
    {
        brain.transform.GetComponent<RectTransform>().DOLocalMoveX(0f,1f).SetEase(Ease.OutBack);
        startButton.transform.GetComponent<RectTransform>().DOLocalMoveY(-250f,1f).SetEase(Ease.OutBack);


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame(){
        SceneManager.LoadScene("GameLevel");
    }
}
