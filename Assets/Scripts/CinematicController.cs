using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Playables; // Asegúrate de incluir esto para usar Timeline

public class CinematicController : MonoBehaviour
{
    public PlayableDirector director; // Referencia al PlayableDirector

    void Start()
    {
        // Reproducir la cinemática al iniciar
        director.Play();
        // Llama a la función para cargar la escena del juego después de que la cinemática termine
        StartCoroutine(WaitForCinematicEnd());
    }

    IEnumerator WaitForCinematicEnd()
    {
        // Espera hasta que la cinemática termine
        yield return new WaitForSeconds((float)director.duration);
        // Carga la escena del juego
        SceneManager.LoadScene("EscenaPrincipal");
    }
}
