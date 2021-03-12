using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class AgentFlip : MonoBehaviour
{
    protected SpriteRenderer spriteRenderer;
    
    public void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    
    public void FaceDirection(Vector2 pointOfInterest)
    {
        var direction = (Vector3) pointOfInterest - transform.position;
        
        //If mouse pointer is on the left the cross product will be positive, and if on the right negative.
        var result = Vector3.Cross(Vector2.up,direction);
        if (result.z > 0)
        {
            spriteRenderer.flipX = true;
        } else if (result.z < 0)
        {
            spriteRenderer.flipX = false;
        }
    }
}
