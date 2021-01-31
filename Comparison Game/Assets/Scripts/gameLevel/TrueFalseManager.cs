using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class TrueFalseManager : MonoBehaviour
{
    [SerializeField]
    private GameObject trueIcon, falseIcon;

    void Start()
    {
        closeTrueOrFalseScale();
    }

    public void openTrueFalseScale(bool isTrueOrFalse)
    {

        if (isTrueOrFalse)
        {
            trueIcon.GetComponent<RectTransform>().DOScale(1, 0.3f);
            falseIcon.GetComponent<RectTransform>().localScale = Vector2.zero;
        }
        else
        {
            falseIcon.GetComponent<RectTransform>().DOScale(1, 0.3f);
            trueIcon.GetComponent<RectTransform>().localScale = Vector2.zero;
        }
        Invoke("closeTrueOrFalseScale", 0.5f);
    }

    void closeTrueOrFalseScale()
    {
        trueIcon.GetComponent<RectTransform>().localScale = Vector2.zero;
        falseIcon.GetComponent<RectTransform>().localScale = Vector2.zero;
    }


}
