using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public abstract class AudioPlayer : MonoBehaviour
{
    protected AudioSource _audioSource;

    [field: SerializeField] 
    protected float pitchRandomness = 0.05f;
    protected float basePitch;

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    private void Start()
    {
        basePitch = _audioSource.pitch;
    }

    protected void ClipVariablePitch(AudioClip clip)
    {
        var randomPitch = UnityEngine.Random.Range(-pitchRandomness, pitchRandomness);
        _audioSource.pitch = basePitch + randomPitch;
        PlayClip(clip);
    }

    protected void PlayClip(AudioClip clip)
    {
        _audioSource.Stop();
        _audioSource.clip = clip;
        _audioSource.Play();
    }

}
