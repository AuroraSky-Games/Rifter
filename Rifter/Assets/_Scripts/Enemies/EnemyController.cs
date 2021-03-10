using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyController : MonoBehaviour
{

    [field: SerializeField] public UnityEvent<Vector2> MovementPressed { get; set; }
    [field: SerializeField] public UnityEvent<Vector2> MovementReleased { get; set;}
    [field: SerializeField] public UnityEvent<Vector2> OnTargetChange { get; set; }
    [field: SerializeField] public UnityEvent<float> OnVelocityChange { get; set; }
    [field: SerializeField] public UnityEvent FirePressed { get; set; }
    [field: SerializeField] public UnityEvent FireReleased { get; set; }
    

}
