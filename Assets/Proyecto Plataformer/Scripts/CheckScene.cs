using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using MoreMountains.Tools;

public class CheckScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int actualScene = SceneManager.GetActiveScene().buildIndex;

        if(actualScene == 3){
            MMAchievementManager.UnlockAchievement("Skill Issue");
        }
        if(actualScene == 6)
        {
            MMAchievementManager.UnlockAchievement("Going Further");
        }
        if(actualScene == 7)
        {
            MMAchievementManager.UnlockAchievement("Run Bitch");
        }
        if(actualScene == 8)
        {
            MMAchievementManager.UnlockAchievement("Hitler is that you?");
        }
    }
}
