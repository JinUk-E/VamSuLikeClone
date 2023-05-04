using System.Collections.Generic;
using UnityEngine;

public class SoundManager : AtGameSingleton<SoundManager>
{
    public static SoundManager Instance => instance ?? (instance = new SoundManager());
    
    // sound list
    private Dictionary<string, AudioClip> soundList = new();
    
    // sound source
    private AudioSource audioSource = new();
    
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
    
    // Sound Dictionary Clear
    public void ClearSoundList() => soundList.Clear();
}
