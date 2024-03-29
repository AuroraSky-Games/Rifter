using System.Collections;
using System.Collections.Generic;
using _Scripts;
using UnityEngine;

public class WeaponAudioPlayer : AudioPlayer
{

    [SerializeField] private AudioClip shootBulletClip = null, outOfBulletsClip = null, reloadClip = null;

    public void PlayShootSound()
    {
        PlayClip(shootBulletClip);
    }

    public void PlayNoBulletsSound()
    {
        PlayClip(outOfBulletsClip);
    }

    public void PlayReloadSound()
    {
        PlayClip(reloadClip);
    }
    
}
