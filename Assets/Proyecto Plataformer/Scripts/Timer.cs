using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI timerText;
    [SerializeField] public float remainingTime;
    public float achieveTime;

    // Start is called before the first frame update
    void Start()
    {
        remainingTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        remainingTime += Time.deltaTime;

        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime - minutes * 60);
        int miliseconds = Mathf.FloorToInt((remainingTime - (int)remainingTime) * 1000);

        timerText.text = string.Format("{0:00}:{1:00}:{2:000}", minutes, seconds, miliseconds);
    }
}