using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public float timeLeft;
    public bool timerOn = false;

    public TextMeshProUGUI timerText;

    // Start is called before the first frame update
    void Start()
    {
        timerOn = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (timerOn)
        {
            if (timeLeft > 0) 
            {
                timeLeft -= Time.deltaTime;
                updateTimer(timeLeft);
            }
            else
            {
                Debug.Log("Time Up!");
                timeLeft = 0;
                timerOn = false;
            }
        }
    }

    void updateTimer(float time)
    {
        time += 1;

        float minutes = Mathf.FloorToInt(time / 60);
        float seconds = Mathf.FloorToInt(time % 60);

        timerText.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }
}
