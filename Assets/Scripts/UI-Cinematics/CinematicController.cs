using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Playables; // Asegúrate de incluir esto para usar Timeline
using UnityEngine.Video;

public class CinematicController : MonoBehaviour
{
    public VideoClip cinematic;
    public PlayableDirector director; // Referencia al PlayableDirector
    public VideoPlayer reproductor;

    void Start()
    {
        cinematic = Resources.Load<VideoClip>("mp4/Comp 1");
        reproductor.clip = cinematic;
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
        SceneManager.LoadScene("InicioJuego");
    }
}
