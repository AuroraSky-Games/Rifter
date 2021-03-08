using System.Collections;
using System.Collections.Generic;
using _Scripts;
using UnityEngine;

public class AgentSounds : AudioPlayer
{
    [SerializeField] private AudioClip hitClip = null, deathClip = null, voiceLineClip = null;

    public void PlayerHitSound()
    {
        PlayClip(hitClip);
    }

    public void PlayDeathSound()
    {
        PlayClip(deathClip);
    }

    public void PlayVoiceLine()
    {
        PlayClip(voiceLineClip);
    }
    
}
