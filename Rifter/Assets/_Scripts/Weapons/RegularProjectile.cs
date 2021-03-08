using System;
using System.Collections;
using System.Collections.Generic;
using _Scripts.Interfaces;
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
    
    private void OnEnable()
    {
        StartCoroutine(DestroyBulletAfterTime());   
    }
    
    private void FixedUpdate()
    {
        if (_rigidbody2D != null && ProjectileData != null)
        {
            _rigidbody2D.MovePosition(transform.position + ProjectileData.Speed * transform.right*Time.fixedDeltaTime);
        }
    }
    
    IEnumerator DestroyBulletAfterTime()
    {
        yield return new WaitForSeconds(3f);
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        var hittable = collision.GetComponent<IHittable>();
        hittable?.GetHit(ProjectileData.Damage, gameObject);
        
        if (collision.tag.Equals("Enemy"))
        {
            
            HitEnemy();
            
        } else if (collision.tag.Equals("Obstacle"))
        {
            
            HitObstacle();
            
        }
        
        Destroy(gameObject);
    }

    private void HitObstacle()
    {
        Debug.Log("Hitting obstacle");
    }

    private void HitEnemy()
    {
        Debug.Log("Hitting Enemy");
    }
    
}
