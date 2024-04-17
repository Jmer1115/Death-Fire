using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
using UnityEngine.SceneManagement;

public class CambiarNivel : MonoBehaviour
{
    int actualScene;

    public void Start()
    {
        actualScene = SceneManager.GetActiveScene().buildIndex;
    }

    public void OnCambiarDeNivel()
    {
        if(actualScene == 5)
        {
            MMAchievementManager.UnlockAchievement("Going Further");
            MMSceneLoadingManager.LoadScene("Nivel 2"); 
        }

        if(actualScene == 6)
        {
            MMSceneLoadingManager.LoadScene("Nivel 3"); 
            MMAchievementManager.UnlockAchievement("Run Bitch");
        }
        
    }
}
