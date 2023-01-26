using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Sound
{
    public SoundCategory soundCategory;
    public string soundName;
    public bool mute;
    public AudioClip clip;
    [Range(0,1)]public float volume;
    [Range(-5,5)]public float pitch;
    [HideInInspector] public AudioSource source;
}
public enum SoundCategory{
    Music,
    SFX
}
