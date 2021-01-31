using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class CountDownManager : MonoBehaviour
{

    [SerializeField]
    private GameObject countDownImage;

    [SerializeField]
    private Text countDownText;

    GameManager gameManager;

    private void Awake()
    {
        gameManager = Object.FindObjectOfType<GameManager>();

    }
    void Start()
    {
        StartCoroutine(countDownRoutine());

    }

    IEnumerator countDownRoutine()
    {

        countDownText.text = "3";
        yield return new WaitForSeconds(0.5f);
        countDownImage.transform.GetComponent<RectTransform>().DOScale(1, 0.5f).SetEase(Ease.OutBack);
        yield return new WaitForSeconds(0.5f);
        countDownImage.transform.GetComponent<RectTransform>().DOScale(0, 0.5f).SetEase(Ease.InBack);
        yield return new WaitForSeconds(0.5f);

        countDownText.text = "2";
        yield return new WaitForSeconds(0.5f);
        countDownImage.transform.GetComponent<RectTransform>().DOScale(1, 0.5f).SetEase(Ease.OutBack);
        yield return new WaitForSeconds(0.5f);
        countDownImage.transform.GetComponent<RectTransform>().DOScale(0, 0.5f).SetEase(Ease.InBack);
        yield return new WaitForSeconds(0.5f);
        countDownText.text = "1";
        yield return new WaitForSeconds(0.5f);
        countDownImage.transform.GetComponent<RectTransform>().DOScale(1, 0.5f).SetEase(Ease.OutBack);
        yield return new WaitForSeconds(0.5f);
        countDownImage.transform.GetComponent<RectTransform>().DOScale(0, 0.5f).SetEase(Ease.InBack);
        yield return new WaitForSeconds(0.5f);

        StopAllCoroutines();


        gameManager.StartGame();


    }
}
