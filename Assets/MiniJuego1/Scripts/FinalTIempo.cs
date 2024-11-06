using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FinalTIempo : MonoBehaviour
{
    public void Reintentar()
    {
        SceneManager.LoadScene("Cuadro");
    }

    public void Regresar()
    {
        SceneManager.LoadScene("Room2");
    }
}
