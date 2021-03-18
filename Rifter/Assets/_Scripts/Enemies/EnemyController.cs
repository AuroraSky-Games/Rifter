using System;
using _Scripts;
using _Scripts.Enemies.AI;
using _Scripts.Player;
using UnityEngine;
using UnityEngine.Events;


public class EnemyController : MonoBehaviour
{
    [field: SerializeField] protected SOAgentStats AgentStats { get; set; }
    [field: SerializeField] public GameObject Target { get; set; }
    [field: SerializeField] public AIState CurrentState { get; private set; }
    [field: SerializeField] public UnityEvent<Vector2> OnTargetChange { get; set; }
    [field: SerializeField] public UnityEvent<Vector2> OnRun { get; set; }
    [field: SerializeField] public UnityEvent<Vector2> OnStop { get; set;}
    [field: SerializeField] public UnityEvent<float> OnVelocityChange { get; set; }
    [field: SerializeField] public UnityEvent OnAttack { get; set; }
    [field: SerializeField] public UnityEvent OnStopAttack { get; set; }

    private void Awake()
    {
        Target = FindObjectOfType<Player>().gameObject; 
    }

    private void Update()
    {
        if (Target == null)
        {
            OnRun?.Invoke(Vector2.zero);
        }
        CurrentState.UpdateState();
    }

    public void Attack()
    {
        OnAttack?.Invoke();
    }

    public void Move(Vector2 movementDirection, Vector2 targetPosition)
    {
        OnRun?.Invoke(movementDirection);
        OnTargetChange?.Invoke(targetPosition);
    }

    public void ChangeToState(AIState state)
    {
        CurrentState = state;
    }

}

