using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        // Cambia "IntroCinematic" por el nombre de la escena de la cinemática
        SceneManager.LoadScene("IntroCinematic");
    }

    public void ShowCredits()
    {
        SceneManager.LoadScene("CreditsScene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
