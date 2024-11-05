using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorTiempo : MonoBehaviour
{
    [SerializeField] private float TiempoMaximo;
    [SerializeField] private Slider slider;
    private float tiempoActual;
    public bool tiempoActivado = false;

    public GameObject FinalTiempo;

    void Start()
    {
        ActivarTemporizador();
        FinalTiempo.SetActive(false);
    }

    void Update()
    {
        if (tiempoActivado)
        {
            CambiarContador();
        }
    }
    //Metodo para cuando el temporizador llega a cero
    private void CambiarContador()
    {
        tiempoActual -= Time.deltaTime;

        if (tiempoActual >= 0)
        {
            slider.value = tiempoActual;
        }

        if (tiempoActual <= 0)
        {
            Time.timeScale = 0f;
            Debug.Log("Perdisteeeee");
            FinalTiempo.SetActive(true);
            CambiarTemporizador(false);
        }
    }

    //Metodo para cambiar el temporizador
    private void CambiarTemporizador(bool estado)
    {
        tiempoActivado = estado;
    }

    public void ActivarTemporizador()
    {
        tiempoActual = TiempoMaximo;
        slider.maxValue = TiempoMaximo;
        CambiarTemporizador(true);
    }

    public void DesactivarTemporizador()
    {
        CambiarTemporizador(false);
        Time.timeScale = 0;
    }
}
