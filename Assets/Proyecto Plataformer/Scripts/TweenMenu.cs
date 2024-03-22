using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TweenMenu : MonoBehaviour
{
    [SerializeField] private GameObject groupLetrero;
    [SerializeField] public int alturaFinal;

    void Start()
    {
        LeanTween.moveY(groupLetrero.GetComponent<RectTransform>(), alturaFinal, 0.8f)
        .setEase(LeanTweenType.easeInCirc);
    }

}
