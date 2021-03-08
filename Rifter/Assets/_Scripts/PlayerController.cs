using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{

    private Camera mainCamera;

    [field: SerializeField]
    private float currentVelocity = 5;

    protected Vector2 movementDirection;

    [field: SerializeField] public UnityEvent<float> OnVelocityChange { get; set; }

    [field: SerializeField] public UnityEvent<Vector2> OnPointerChange { get; set; }
    
    [field: SerializeField] public SOAgentStats AgentStats { get; set; }
    
    protected Rigidbody2D _rigidbody2D;
    private Vector2 movementInput = Vector2.zero;
    private Vector2 pointerInput = Vector2.zero;

    //Used in editor to read input from new input system. 
    public void OnMove(InputAction.CallbackContext context)
    {
        movementInput = context.ReadValue<Vector2>();
    }

    public void OnPointerMovement(InputAction.CallbackContext context)
    {
        pointerInput = context.ReadValue<Vector2>();
    }

    private void Start()
    {
        mainCamera = Camera.main;
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector2 move = new Vector2(movementInput.x, movementInput.y);
        var pointer = new Vector3(pointerInput.x, pointerInput.y);
        GetPointerInput();
        moveAgent(move);
    }

    public void GetPointerInput()
    {
        var mouseInWorldSpace = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        OnPointerChange?.Invoke(mouseInWorldSpace);
    }

    public void moveAgent(Vector2 momentInput)
    {
        movementDirection = momentInput;
        currentVelocity = CalculateSpeed(movementInput);
    }

    private float CalculateSpeed(Vector2 movementInput)
    {
        if (movementInput.magnitude > 0)
        {
            currentVelocity += AgentStats.acceleration * Time.deltaTime;
        }
        else
        {
            currentVelocity -= AgentStats.deAcceleration * Time.deltaTime;
        }

        return Mathf.Clamp(currentVelocity, 0, AgentStats.maxSpeed);
    }

    private void FixedUpdate()
    {
        OnVelocityChange?.Invoke(currentVelocity);
        _rigidbody2D.velocity = currentVelocity * movementDirection.normalized;
    }
}
