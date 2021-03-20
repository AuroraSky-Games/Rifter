using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class AvatarAnimations : MonoBehaviour
{
    private Animator _avatarAnimator;
    private static readonly int run = Animator.StringToHash("Run");
    
    private void Awake()
    {
        _avatarAnimator = GetComponent<Animator>();
    }

    private void SetWalkAnimation(bool val)
    {
        _avatarAnimator.SetBool(run, val);
    }

    public void AnimatePlayer(float velocity)
    {
        SetWalkAnimation(velocity > 0);
    }
    
}


