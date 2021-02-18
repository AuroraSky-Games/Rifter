using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AgentStepAudioPlayer : MonoBehaviour
{
    protected AudioSource _audioSource;

    [field: SerializeField] 
    protected float pitchRandomness = 0.05f;
    protected float basePitch;

    [field: SerializeField]
    protected AudioClip stepClip;

    private void LateUpdate()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    protected void ClipVariablePitch(AudioClip clip)
    {
        PlayClip(clip);
    }

    protected void PlayClip(AudioClip clip)
    {
        _audioSource.Stop();
        _audioSource.clip = clip;
        _audioSource.Play();
    }

    public void PlayStepSound()
    {
        ClipVariablePitch(stepClip);
    }
    
}
