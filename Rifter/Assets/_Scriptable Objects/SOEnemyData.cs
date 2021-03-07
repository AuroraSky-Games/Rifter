using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Enemies/EnemyData")]
public class SOEnemyData : ScriptableObject
{

    [field: SerializeField] public int MaxHealth { get; set; } = 3;

    [field: SerializeField] public int Damage { get; set; } = 1;

}
