using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MiniJuego1 : MonoBehaviour
{
    private bool isNearObject;
    public GameObject miniOne;

    void Start()
    {
        miniOne.SetActive(false);
    }

    void Update()
    {
        if (isNearObject && Input.GetKeyDown(KeyCode.E)) // Usa la tecla E para interactuar
        {
            miniOne.SetActive(true);
        }
    }

    public void OnConfirm()
    {
        // Aquí puedes cargar la siguiente escena
        SceneManager.LoadScene("Cuadro");
    }

    public void OnCancel()
    {
        miniOne.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isNearObject = true; 
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isNearObject = false;
        }
    }
}
