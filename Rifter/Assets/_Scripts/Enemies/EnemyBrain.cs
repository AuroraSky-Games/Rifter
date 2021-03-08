using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyBrain : MonoBehaviour
{
    
    [field: SerializeField] public UnityEvent FirePressed { get; set; }
    [field: SerializeField] public UnityEvent FireReleased { get; set; }
    [field: SerializeField] public UnityEvent<Vector2> MovementPressed { get; set; }
    [field: SerializeField] public UnityEvent<Vector2> MovementReleased { get; set; }

}
