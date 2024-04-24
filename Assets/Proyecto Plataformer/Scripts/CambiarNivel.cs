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
            MMSceneLoadingManager.LoadScene("Nivel 2"); 
        }

        if(actualScene == 6)
        {
            MMSceneLoadingManager.LoadScene("Nivel 3"); 
        }

        if(actualScene == 7)
        {
            MMSceneLoadingManager.LoadScene("Final"); 
        }
        
    }
}
