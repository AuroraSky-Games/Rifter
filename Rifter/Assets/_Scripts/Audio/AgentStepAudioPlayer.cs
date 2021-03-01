using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AgentStepAudioPlayer : AudioPlayer
{

    [field: SerializeField]
    protected AudioClip stepClip;

    public void PlayStepSound()
    {
        ClipVariablePitch(stepClip);
    }
    
}
