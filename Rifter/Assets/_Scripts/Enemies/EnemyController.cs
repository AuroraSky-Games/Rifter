using System;
using _Scripts.Enemies.AI;
using UnityEngine;
using UnityEngine.Events;

namespace _Scripts.Enemies
{
    public class EnemyController : MonoBehaviour
    {

        [field: SerializeField] public GameObject Target { get; set; }
        [field: SerializeField] public UnityEvent<Vector2> OnTargetChange { get; set; }
        
        [field: SerializeField] public UnityEvent<Vector2> Run { get; set; }
        [field: SerializeField] public UnityEvent<Vector2> Stop { get; set;}
        [field: SerializeField] public UnityEvent<float> OnVelocityChange { get; set; }
        [field: SerializeField] public UnityEvent Attack { get; set; }
        [field: SerializeField] public UnityEvent StopAttack { get; set; }

        private void Awake()
        {
            Target = FindObjectOfType<Player.Player>().gameObject;
        }

        public void ChangeToState(AIState transitionPositiveResult)
        {
            throw new NotImplementedException();
        }
    }
}
