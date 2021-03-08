using System;
using System.Collections;
using System.Collections.Generic;
using _Scripts;
using UnityEngine;
using UnityEngine.Events;

public class Enemy : Agent
{
    [field: SerializeField] private SOAgentStats EnemyStats { get; set; }
    
    private void Start()
    {
        Health = EnemyStats.MaxHealth;
    }

    protected override IEnumerator WaitToDie()
    {
        yield return new WaitForSeconds(.53f);
        Destroy(gameObject);
    }
}


