using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Weapons/ProjectileData")]
public class SOProjectileData : ScriptableObject
{
    [field: SerializeField]
    public GameObject ProjectilePrefab { get; set; }

    [field: SerializeField]
    [field: Range(1, 10)]
    public float Speed { get; internal set; } = 1;
    
    [field: SerializeField]
    [field: Range(1, 10)]
    public int Damage { get; set; }

    [field: SerializeField]
    [field: Range(0, 10)]
    public float Friction { get; internal set; } = 0;

    [field: SerializeField]
    public bool Bounce { get; set; }
    
    [field: SerializeField]
    public  bool GoThroughHittable { get; set; }

    [field: SerializeField]
    public bool IsRaycast { get; set; }
    
    [field: SerializeField]
    public GameObject ImpactObstaclePrefab { get; set; }
    
    [field: SerializeField]
    public GameObject ImpactEnemyPrefab { get; set; }

    [field: SerializeField]
    [field: Range(1, 20)]
    public float KnockBackPower { get; set; } = 5;

    [field: SerializeField]
    [field: Range(0.01f, 1f)]
    public float KnockBackDelay { get; set; } = 0.1f;

}