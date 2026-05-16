using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class gameTimer : MonoBehaviour
{
    public TextMeshProUGUI timerText;

    float tiempo = 0f;

    public bool gameOver = false;

    void Update()
    {
        if(gameOver == false)
        {
            tiempo += Time.deltaTime;

            timerText.text = tiempo.ToString("F2");
        }
    }
}