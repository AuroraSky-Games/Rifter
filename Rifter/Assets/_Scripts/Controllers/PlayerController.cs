using _Scripts.Managers;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

namespace _Scripts
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class PlayerController : SystemManager
    {
    
        //Variables
        
        private float _currentVelocity;
        private Vector2 _movementDirection;
        private Rigidbody2D _rigidbody2D;
        private Vector2 _movementInput = Vector2.zero;
        private Vector2 _pointerInput = Vector2.zero;
        private SpriteRenderer _spriteRenderer;

        //Events
    
        [field: SerializeField] private SOAgentStats AgentStats { get; set; }
        [field: SerializeField] private UnityEvent<float> OnVelocityChange { get; set; }
        [field: SerializeField] private UnityEvent<Vector2> OnPointerChange { get; set; }
    
        //Used in editor to read input from new input system. 
        public void OnMove(InputAction.CallbackContext context)
        {
            _movementInput = context.ReadValue<Vector2>();
        }

        public void OnPointerMovement(InputAction.CallbackContext context)
        {
            _pointerInput = context.ReadValue<Vector2>();
        }

        private void Start()
        {
            _spriteRenderer = GetComponent<SpriteRenderer>();
            _rigidbody2D = GetComponent<Rigidbody2D>();
            _currentVelocity = AgentStats.startVelocity;
        }

        private void Update()
        {
            var move = new Vector2(_movementInput.x, _movementInput.y);
            GetPointerInput();
            MoveAgent(move);
        }
    
        private void FixedUpdate()
        {
            OnVelocityChange?.Invoke(_currentVelocity);
            _rigidbody2D.velocity = _currentVelocity * _movementDirection.normalized;
        }

        //Methods

        private void GetPointerInput()  
        {
            var mousePosition = GetMousePosition;
            OnPointerChange?.Invoke(mousePosition);
        }

        private void MoveAgent(Vector2 momentInput)
        {
            _movementDirection = momentInput;
            _currentVelocity = CalculateSpeed(_movementInput);
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
}
