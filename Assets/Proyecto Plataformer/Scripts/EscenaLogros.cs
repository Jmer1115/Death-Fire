using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.CorgiEngine;
using MoreMountains.Tools;

public class EscenaLogros : MonoBehaviour
{

    void Start(){
        LoadAchivementes();
    }

    public static void ResetAchievements(){
        MoreMountains.Tools.MMAchievementManager.ResetAllAchievements();
    }

    public static void LoadAchivementes(){
        MoreMountains.Tools.MMAchievementManager.LoadSavedAchievements();
    }
}
