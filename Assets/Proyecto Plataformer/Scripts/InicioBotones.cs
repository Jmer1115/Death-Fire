using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using MoreMountains.Tools;

public class InicioBotones : MonoBehaviour
{
    [SerializeField] GameObject quitPanel;
    
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

    public void BotonInstrucciones()
    {
        MMSceneLoadingManager.LoadScene("Instrucciones");
    }

    public void AbrirConfirmacion()
    {
        quitPanel.SetActive(true);
    }

    public void CerrarConfirmacion()
    {
        quitPanel.SetActive(false);
    }
}
