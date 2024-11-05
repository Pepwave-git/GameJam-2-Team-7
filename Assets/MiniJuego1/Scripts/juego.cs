using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class juego : MonoBehaviour
{

    public GameObject Terminado;
    public GameObject PiezaSeleccionada;   
    public int PiezasEncajadas = 0;

    [SerializeField] private ControladorTiempo controladorTiempo;


    void Start()
    {
        controladorTiempo.ActivarTemporizador();
        for (int i = 0;i < 16; i++)
        {
            GameObject.Find("Pieza"+i);
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && controladorTiempo.tiempoActivado == true)
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit.transform.CompareTag("Puzzle"))
            {
                if (!hit.transform.GetComponent<pieza>().Encajada)
                {
                    PiezaSeleccionada = hit.transform.gameObject;
                    PiezaSeleccionada.GetComponent<pieza>().Seleccionada = true;
                }
            }
        }

        if (Input.GetMouseButtonUp(0) && PiezaSeleccionada != null)
        {
                PiezaSeleccionada.GetComponent<pieza>().Seleccionada = false;
                PiezaSeleccionada = null;
        }
        if (PiezaSeleccionada != null)
        {
            Vector3 raton = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            PiezaSeleccionada.transform.position = new Vector3(raton.x,raton.y,0);
        }             
        if (PiezasEncajadas == 16)
        {
            controladorTiempo.DesactivarTemporizador();
            Terminado.SetActive(true);
        }
    }
}