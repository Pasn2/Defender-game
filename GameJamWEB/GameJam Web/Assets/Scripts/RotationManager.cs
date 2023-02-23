using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationManager : MonoBehaviour
{
    public static RotationManager instance;
    [SerializeField] ScreenOrientation currentScreenOrientation;
    void Awake()
    {
    
        if (instance != null && instance != this) 
        { 
            Destroy(this); 
        } 
        else{
            instance = this;
        }
    }

    public void ChangePortraiNormal()
    {
        currentScreenOrientation = Screen.orientation;
        if(currentScreenOrientation != ScreenOrientation.Portrait)
        {
            currentScreenOrientation = ScreenOrientation.Portrait;
        }
    }
    public void ChangeLandscape()
    {
        currentScreenOrientation = Screen.orientation;
        if(currentScreenOrientation != ScreenOrientation.LandscapeLeft)
        {
            currentScreenOrientation = ScreenOrientation.LandscapeLeft;
        }
    }
}
