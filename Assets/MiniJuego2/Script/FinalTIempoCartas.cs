using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FinalTIempoCarta : MonoBehaviour
{
    public void Reintentar()
    {
        SceneManager.LoadScene(0);
    }

    public void Regresar()
    {
        Debug.Log("Regresaaaaar");
    }
}
