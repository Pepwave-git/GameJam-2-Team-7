using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ComeBack : MonoBehaviour
{
    private bool isNearObject;

    void Start()
    {

    }


    void Update()
    {
        if (isNearObject && Input.GetKeyDown(KeyCode.E)) // Usa la tecla E para interactuar
        {
            SceneManager.LoadScene("EscenaPrincipal");
        }
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

