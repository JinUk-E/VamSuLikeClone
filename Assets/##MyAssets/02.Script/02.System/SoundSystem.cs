using System.Collections.Generic;
using UnityEngine;

public class SoundSystem
{
    // sound system singleton
    private static SoundSystem instance;
    public static SoundSystem Instance => instance ?? (instance = new SoundSystem());
    
    // sound list
    private Dictionary<string, AudioClip> soundList = new Dictionary<string, AudioClip>();
    
    // sound source
    private AudioSource audioSource;
    
    // sound system constructor
    private SoundSystem()
    {
        // create audio source
        audioSource = new GameObject("SoundSystem").AddComponent<AudioSource>();
        audioSource.playOnAwake = false;
        audioSource.loop = false;
        audioSource.volume = 1f;
        audioSource.spatialBlend = 0f;
        audioSource.dopplerLevel = 0f;
        audioSource.rolloffMode = AudioRolloffMode.Linear;
        audioSource.minDistance = 1f;
        audioSource.maxDistance = 500f;
    }
    
    // add sound
    public void AddSound(string name, AudioClip audioClip) => soundList.Add(name, audioClip);
    
    // play sound
    public void PlaySound(string name, bool loop = false)
    {
        if (!soundList.ContainsKey(name)) return;
        audioSource.clip = soundList[name];
        audioSource.loop = loop;
        audioSource.Play();
    }
    
    // stop sound
    public void StopSound() => audioSource.Stop();
    
    // set sound volume
    public void SetVolume(float volume) => audioSource.volume = volume;
    
    // set sound pitch
    public void SetPitch(float pitch) => audioSource.pitch = pitch;
    
    
}
