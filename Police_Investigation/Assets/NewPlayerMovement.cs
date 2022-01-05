using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewPlayerMovement : MonoBehaviour
{

    private CharacterController _characterController;

    private Vector3 _movementInput;
    private Vector3 _movementDirection;

    public float speed = 2f;
    
    void Start()
    {
        _characterController = GetComponent<CharacterController>();
    }
    
    void Update()
    {
        MovementInput();
        _characterController.Move(_movementDirection * speed * Time.deltaTime);
    }

    void MovementInput()
    {
        _movementInput = NewInputManager.instance.playerInput.Movement.Move.ReadValue<Vector2>();
        _movementDirection =  transform.right * _movementInput.x + transform.forward * _movementInput.y;
    }
}
