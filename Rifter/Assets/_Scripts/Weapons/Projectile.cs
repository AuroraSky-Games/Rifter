using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Projectile : MonoBehaviour
{
    [field: SerializeField]
    public virtual SOProjectileData ProjectileData { get; set; }
}
