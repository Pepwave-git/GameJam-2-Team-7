using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Añade esta línea para usar TextMeshPro

public class CountdownTimer : MonoBehaviour
{
    public TMP_Text timerText; // Cambia de Text a TMP_Text
    private float timeRemaining = 600; // 10 minutos en segundos
    private bool timerRunning = false;
    public Image playerView;

    void Start()
    {
        timerRunning = true;
    }

    void Update()
    {
        if (timerRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);

                if (timeRemaining <= 300 && timeRemaining > 299.9) // Cambio de color a los 5 minutos
                {
                    playerView.color = Color.yellow;
                }
                else if (timeRemaining <= 120 && timeRemaining > 119.9) // Cambio de color a los 2 minutos
                {
                    playerView.color = Color.red;
                }
            }
            else
            {
                timeRemaining = 0;
                timerRunning = false;
            }
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}

