using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

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
        foreach (Sound s in soundsArray)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.mute = s.mute;
        }
    }
    public void PlaySound(string _audioClipName)
    {
        Sound sound = Array.Find(soundsArray,sound => sound.soundName == _audioClipName);
        sound.source.Play();
        
    }
    public void SFXMute()
    {
        foreach (Sound sound in soundsArray)
        {
            if(sound.soundCategory == SoundCategory.SFX)
            {
                sound.source.mute = !sound.source.mute;
            }
        }
    }
    public void MusicMute()
    {
        foreach (Sound sound in soundsArray)
        {
            if(sound.soundCategory == SoundCategory.Music)
            {
                sound.source.mute = !sound.source.mute;
            }
        }
    }
    //
}
