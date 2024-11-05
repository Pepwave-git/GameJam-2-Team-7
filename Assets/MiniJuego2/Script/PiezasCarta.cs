using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class PiezasCarta : MonoBehaviour
{
    private Vector3 PosicionCorrecta;
    public bool Encajada;
    public bool Seleccionada;

    void Start()
    {
        PosicionCorrecta = transform.position;
        transform.position = new Vector3(Random.Range(-8f, 0f), Random.Range(3f, -3f));
    }

    void Update()
    {
        if (Vector3.Distance(transform.position, PosicionCorrecta) < 0.5f)
        {
            if (!Seleccionada && Encajada == false)
            {
                transform.position = PosicionCorrecta;
                Encajada = true;
                Camera.main.GetComponent<JuegoCarta>().PiezasEncajadas++;
            }
        }
    }
}
