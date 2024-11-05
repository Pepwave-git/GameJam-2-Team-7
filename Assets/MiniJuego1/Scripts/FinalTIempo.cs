using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FinalTIempo : MonoBehaviour
{
    public void Reintentar()
    {
        SceneManager.LoadScene(1);
    }

    public void Regresar()
    {
        Debug.Log("Regresaaaaar");
    }
}
