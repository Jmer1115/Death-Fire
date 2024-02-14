using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InicioBotones : MonoBehaviour
{
    public void BotonJugar()
    {
        SceneManager.LoadScene("Nivel 1");
    }

    public void BotonSalir()
    {
        Application.Quit();
    }

    public void BotonInicio()
    {
        SceneManager.LoadScene("Inicio");
    }
}
