using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class gameTimer : MonoBehaviour
{
    public TextMeshProUGUI timerText;

    float tiempo = 0f;

    void Update()
    {
        tiempo += Time.deltaTime;

        timerText.text = tiempo.ToString("F2");
    }
}