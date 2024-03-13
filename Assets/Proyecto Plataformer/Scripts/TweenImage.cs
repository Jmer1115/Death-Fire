using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TweenImage : MonoBehaviour
{
    [SerializeField] private GameObject image;
    [SerializeField] private GameObject inicioGrupo;

    private void Start()
    {
        LeanTween.moveX(image.GetComponent<RectTransform>(), 0, 1.5f).setDelay(1.5f)
        .setEase(LeanTweenType.easeOutBounce).setOnComplete(BajarAlpha);
    }

    private void BajarAlpha()
    {
        LeanTween.alpha(inicioGrupo.GetComponent<RectTransform>(), 0f, 1f).setDelay(0.5f);
        inicioGrupo.GetComponent<CanvasGroup>().blocksRaycasts = false;
    }
}