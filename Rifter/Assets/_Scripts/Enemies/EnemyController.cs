using System;
using _Scripts;
using _Scripts.Enemies.AI;
using _Scripts.Player;
using UnityEngine;
using UnityEngine.Events;


public class EnemyController : MonoBehaviour
{
    
    private Rigidbody2D _rigidbody2D;
    private float _currentVelocity;
    private Vector2 _movementDirection;
    
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
    
    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _currentVelocity = AgentStats.startVelocity;
    }

    private void Update()
    {
        if (Target == null)
        {
            OnRun?.Invoke(Vector2.zero);
        }
        
        CurrentState.UpdateState();
    }
    
    private void FixedUpdate()
    {
        OnVelocityChange?.Invoke(_currentVelocity);
        _rigidbody2D.velocity = _movementDirection.normalized * _currentVelocity;
    }

    public void Attack()
    {
        OnAttack?.Invoke();
    }

    public void MovementData(Vector2 movementDirection, Vector2 targetPosition)
    {
        OnRun?.Invoke(movementDirection);
        OnTargetChange?.Invoke(targetPosition);
    }

    public void ChangeToState(AIState state)
    {
        CurrentState = state;
    }
    
    public void MoveAgent(Vector2 movementInput)
    {
        _movementDirection = movementInput;
        _currentVelocity = CalculateSpeed(movementInput);
    }
    
    private float CalculateSpeed(Vector2 movementInput)
    {
        if (movementInput.magnitude > 0)
        {
            _currentVelocity += AgentStats.acceleration * Time.deltaTime;
        }
        else
        {
            _currentVelocity -= AgentStats.deAcceleration * Time.deltaTime;
        }

        return Mathf.Clamp(_currentVelocity, 0, AgentStats.maxSpeed);
    }

}

