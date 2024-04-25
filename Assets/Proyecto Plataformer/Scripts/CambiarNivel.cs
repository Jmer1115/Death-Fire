using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
using UnityEngine.SceneManagement;
using MoreMountains.CorgiEngine;

public class CambiarNivel : MonoBehaviour
{
    int actualScene;
    public void Start()
    {
        actualScene = SceneManager.GetActiveScene().buildIndex;
    }

    public void OnCambiarDeNivel()
    {
        SceneManager.LoadScene(actualScene + 1);
    }
}
