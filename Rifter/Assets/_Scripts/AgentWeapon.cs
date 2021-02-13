using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AgentWeapon : MonoBehaviour
{
    protected float desiredAngle;

    [SerializeField] 
    protected SpriteRenderer weaponRenderer;

    private void Awake()
    {
        weaponRenderer = GetComponent<SpriteRenderer>();
    }

    public virtual void AimWeapon(Vector2 pointerPositition)
    {
        //Calculating weapon rotation for aim
        var aimDirection = (Vector3) pointerPositition - transform.position;
        desiredAngle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(desiredAngle, Vector3.forward);
    }
    
}
