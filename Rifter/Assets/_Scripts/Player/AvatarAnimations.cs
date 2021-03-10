using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class AvatarAnimations : MonoBehaviour
{
    private Animator avatarAnimator;

    private void Start()
    {
        avatarAnimator = GetComponent<Animator>();
    }

    private void SetWalkAnimation(bool val)
    {
        avatarAnimator.SetBool("Run", val);
    }

    public void AnimatePlayer(float velocity)
    {
        SetWalkAnimation(velocity > 0);
    }
    
}


