using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject instrucciones;
    public GameObject creditos;

    void start()
    {
        instrucciones.SetActive(false);
        creditos.SetActive(false);
    }

    public void StartGame()
    {
        // Cambia "IntroCinematic" por el nombre de la escena de la cinemática
        SceneManager.LoadScene("IntroCinematic");
    }

    public void ShowCredits()
    {
        creditos.SetActive(true);
    }

    public void CloseCreditd()
    {
        creditos.SetActive(false);

    }

    public void Instrucciones()
    {
        instrucciones.SetActive(true);
    }

    public void CloseInstr()
    {
        instrucciones.SetActive(false);
    }
}
