using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
using UnityEngine.SceneManagement;
using MoreMountains.CorgiEngine;

public class CambiarNivel : MonoBehaviour
{
    int actualScene;

    [SerializeField] Timer timerLevel2;

    public void Start()
    {
        actualScene = SceneManager.GetActiveScene().buildIndex;
    }

    private void Update()
    {
        Debug.Log(timerLevel2.remainingTime < 30);
    }

    public void OnCambiarDeNivel()
    {
        //SceneManager.LoadScene(actualScene + 1);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Duro");

        if (timerLevel2.remainingTime <= 30)
        {
            MMAchievementManager.UnlockAchievement("Fast as F");
        }
    }
}
