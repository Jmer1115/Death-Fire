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
            MMAchievementManager.AchievementsList[4].UnlockedStatus = true;
            SaveAchivs();
        }
        if(actualScene == 6)
        {
            MMAchievementManager.UnlockAchievement("Going Further");
            MMAchievementManager.AchievementsList[1].UnlockedStatus = true;
            SaveAchivs();
        }
        if(actualScene == 7)
        {
            MMAchievementManager.UnlockAchievement("Run Bitch");
            MMAchievementManager.AchievementsList[2].UnlockedStatus = true;
            SaveAchivs();
        }
        if(actualScene == 8)
        {
            MMAchievementManager.UnlockAchievement("Hitler is that you?");
            MMAchievementManager.AchievementsList[3].UnlockedStatus = true;
            SaveAchivs();
        }
    }

    public static void SaveAchivs() {
        MMAchievementManager.SaveAchievements();
    }
}
