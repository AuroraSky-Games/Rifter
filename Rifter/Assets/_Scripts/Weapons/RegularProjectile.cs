using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegularProjectile : Projectile
{
    protected Rigidbody2D _rigidbody2D;

    public override SOProjectileData ProjectileData
    {
        get => base.ProjectileData;
        set
        {
            base.ProjectileData = value;
            _rigidbody2D = GetComponent<Rigidbody2D>();
            _rigidbody2D.drag = ProjectileData.Friction; 
        }
    }

    private void FixedUpdate()
    {
        if (_rigidbody2D != null && ProjectileData != null)
        {
            _rigidbody2D.MovePosition(transform.position + ProjectileData.Speed * transform.right*Time.fixedDeltaTime);
        }
    }
}
