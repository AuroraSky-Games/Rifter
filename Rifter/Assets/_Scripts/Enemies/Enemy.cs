using System;
using System.Collections;
using System.Collections.Generic;
using _Scripts.Abstract_Classes;
using _Scripts.Interfaces;
using UnityEngine;
using UnityEngine.Events;

public class Enemy : Agent
{

    [field: SerializeField] public SOEnemyData EnemyData { get; set; }
    
    private void Start()
    {
        Health = EnemyData.MaxHealth;
    }
    
}


