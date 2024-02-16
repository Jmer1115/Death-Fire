using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using MoreMountains.Tools;

public class InicioBotones : MonoBehaviour
{
    public void BotonJugar()
    {
        MMSceneLoadingManager.LoadScene("Nivel 1");
    }

    public void BotonSalir()
    {
        Application.Quit();
    }

    public void BotonInicio()
    {
        MMSceneLoadingManager.LoadScene("Inicio");
    }
}
