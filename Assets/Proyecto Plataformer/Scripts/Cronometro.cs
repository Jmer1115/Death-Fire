using MoreMountains.Tools;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cronometro : MonoBehaviour
{
    [SerializeField] Timer timerLevel2;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Duro");

        if (timerLevel2.remainingTime <= 30)
        {
            MMAchievementManager.UnlockAchievement("Fast as F");
        }
    }
}
