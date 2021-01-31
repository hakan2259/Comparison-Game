using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class CirclesManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] circlesArray;

    void Start()
    {
        turnOffCirclesScale();
    }

    void turnOffCirclesScale(){
      foreach(GameObject circle in circlesArray){
          circle.transform.GetComponent<RectTransform>().localScale=Vector2.zero;
      }
    }

    public void turnOnCirclesScale(int whichCircle){
        circlesArray[whichCircle].transform.GetComponent<RectTransform>().DOScale(1,0.5f);

    }
} 
