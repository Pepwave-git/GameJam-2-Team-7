using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class InteractionHandler : MonoBehaviour
{
    public GameObject confirmationPanel;
    private bool isNearObject = false;

    void Update()
    {
        if (isNearObject && Input.GetKeyDown(KeyCode.E)) // Usa la tecla E para interactuar
        {
            ShowConfirmationPanel();
        }
    }

    void ShowConfirmationPanel()
    {
        confirmationPanel.SetActive(true);
    }

    public void OnConfirm()
    {
        // Aquí puedes cargar la siguiente escena
        SceneManager.LoadScene("Room2");
    }

    public void OnCancel()
    {
        confirmationPanel.SetActive(false);
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
