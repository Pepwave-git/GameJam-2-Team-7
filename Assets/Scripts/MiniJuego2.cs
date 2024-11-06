using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MiniJuego2 : MonoBehaviour
{
    private bool isNearObject;
    public GameObject miniTwo;

    void Start()
    {
        miniTwo.SetActive(false);
    }


    void Update()
    {
        if (isNearObject && Input.GetKeyDown(KeyCode.E)) // Usa la tecla E para interactuar
        {
            miniTwo.SetActive(true);
        }
    }

    public void OnConfirm2()
    {
        // Aquí puedes cargar la siguiente escena
        SceneManager.LoadScene("Carta");
    }

    public void OnCancel2()
    {
        miniTwo.SetActive(false);
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
