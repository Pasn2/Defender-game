using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public float currentLevelTime;
    bool isCounting = false;
    [SerializeField] TMP_Text timerText;
    float minutes;
    float secounds;
    void Start()
    {
        StartTimer();
    }
    void Update()
    {
        if(isCounting)
        {
            currentLevelTime += Time.deltaTime;
            DisplayTime();
        }
    }
    void DisplayTime(){
        float miliesecounds = (currentLevelTime % 1) * 1000;
        minutes = Mathf.FloorToInt(currentLevelTime / 60);
        secounds = Mathf.FloorToInt(currentLevelTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}:{2:000}",minutes,secounds,miliesecounds);
    }
    public void StartTimer()
    {
        isCounting = true;
    }
    public void StopTimer()
    {
         isCounting = false;
    }
}
