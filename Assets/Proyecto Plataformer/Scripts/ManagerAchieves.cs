using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.CorgiEngine;
using MoreMountains.Tools;
using Unity.VisualScripting;

public class ManagerAchieves : MonoBehaviour
{
    private Health salud_personaje;
    private GameObject _fadeObject;

    public void getHealth()
    {
        _fadeObject = LevelManager.Instance.Players[0].gameObject;

        salud_personaje = _fadeObject.GetComponent<Health>();
    }

    void OnTriggerEnter2D(Collider2D other){
        getHealth();

        if (other.CompareTag("Player")){
                if (salud_personaje.CurrentHealth == salud_personaje.InitialHealth){
                MMAchievementManager.UnlockAchievement("NoHit");
                MMAchievementManager.AchievementsList[9].UnlockedStatus = true;
                MMAchievementManager.SaveAchievements();
            } 
        }
    }
}
