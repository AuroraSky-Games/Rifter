using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    [field: SerializeField]
    private float playerVelocity = 5;
    
    protected Rigidbody2D _rigidbody2D;
    private Vector2 movementInput = Vector2.zero;

    //Used in editor to read input from new input system. 
    public void OnMove(InputAction.CallbackContext context)
    {
        movementInput = context.ReadValue<Vector2>();
    }

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        
        Vector2 move = new Vector2(movementInput.x, movementInput.y);

        moveAgent(move);
        
    }

    public void moveAgent(Vector2 momentInput)
    {
        _rigidbody2D.velocity = movementInput.normalized * playerVelocity;
    }
    
}
