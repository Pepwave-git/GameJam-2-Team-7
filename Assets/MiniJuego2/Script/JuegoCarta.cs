using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class JuegoCarta : MonoBehaviour
{
    public GameObject Terminado;
    public GameObject PiezaSeleccionada;
    public int PiezasEncajadas = 0;
    public AudioSource audioSource;

    [SerializeField] private ControladorTiempoCarta controladorTiempo;

    void Start()
    {
        audioSource.Play();
        audioSource = GetComponent<AudioSource>();
        controladorTiempo = FindAnyObjectByType<ControladorTiempoCarta>();
        controladorTiempo.ActivarTemporizador();
        for (int i = 0; i < 6; i++)
        {
            GameObject.Find("Pieza" + i);
        }
        Terminado.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && controladorTiempo.tiempoActivado == true)
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero, LayerMask.GetMask("Piezas"));
            if (hit.transform.CompareTag("Puzzle"))
            {
                if (!hit.transform.GetComponent<PiezasCarta>().Encajada)
                {
                    PiezaSeleccionada = hit.transform.gameObject;
                    PiezaSeleccionada.GetComponent<PiezasCarta>().Seleccionada = true;
                }
            }
        }

        if (Input.GetMouseButtonUp(0) && PiezaSeleccionada != null)
        {
            PiezaSeleccionada.GetComponent<PiezasCarta>().Seleccionada = false;
            PiezaSeleccionada = null;
        }
        if (PiezaSeleccionada != null)
        {
            Vector3 raton = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            PiezaSeleccionada.transform.position = new Vector3(raton.x, raton.y, 0);
        }
        if (PiezasEncajadas == 6)
        {
            controladorTiempo.DesactivarTemporizador();
            Terminado.SetActive(true);
            audioSource.Pause();
        }


    }
}
