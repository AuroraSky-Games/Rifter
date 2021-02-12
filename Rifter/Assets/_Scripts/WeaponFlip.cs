using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class WeaponFlip : MonoBehaviour
{
    protected SpriteRenderer spriteRenderer;

    public void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void FaceDirection(Vector2 pointerInput)
    {
        var direction = (Vector3) pointerInput - transform.position;
        
        //If mouse pointer is on the left the cross product will be positive, and if on the right negative.
        var result = Vector3.Cross(Vector2.up,direction);
        if (result.z > 0)
        {
            spriteRenderer.flipY = true;
        } else if (result.z < 0)
        {
            spriteRenderer.flipY = false;
        }
    }
}