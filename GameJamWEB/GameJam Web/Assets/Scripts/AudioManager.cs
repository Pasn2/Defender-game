using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    [SerializeField] Sound[] soundsArray;
    private AudioSource audioSource;
    private void Awake() 
    {
        if (instance != null && instance != this) 
        { 
            Destroy(this); 
        } 
        else{
            instance = this;
        }
    }
    
    public void PlaySound(string _audioClipName)
    {
        foreach (Sound sound in soundsArray)
        {
            if(sound.soundName == _audioClipName)
            {

            }
        }
        
    }
}
