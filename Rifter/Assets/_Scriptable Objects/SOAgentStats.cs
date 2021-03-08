using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Agent/Stats")]
public class SOAgentStats : ScriptableObject
{

    [field: SerializeField] public int MaxHealth { get; set; } = 3;

    [field: SerializeField] public int Damage { get; set; } = 1;
    
    [Range(1,10)]
    public float startVelocity  = 5;
    
    [Range(1,10)]
    public float maxSpeed = 5;

    [Range(0.1f, 100)]
    public float acceleration = 50, deAcceleration = 50;

}
