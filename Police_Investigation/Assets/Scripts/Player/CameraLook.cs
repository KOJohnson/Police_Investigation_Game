using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLook : MonoBehaviour
{
    public Transform Player;
    
    private Vector3 _mouseLook;

    private float _xRotation = 0f;
    private float xClamp = 75f;
    
    [SerializeField] private float camSensitivity = 5f;
    private float _mouseX;
    private float _mouseY;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    
    // Update is called once per frame
    private void Update()
    {
        LookInput();
        
        _xRotation -= _mouseY;
        _xRotation = Mathf.Clamp(_xRotation, -xClamp, xClamp);

        transform.localRotation = Quaternion.Euler(_xRotation, 0f, 0f);
        Player.Rotate(Vector3.up * _mouseX, Space.World);
    }

    private void LookInput()
    {
        _mouseLook = NewInputManager.instance.playerInput.MouseLook.LookVector.ReadValue<Vector2>();
            
        _mouseX = _mouseLook.x * camSensitivity * Time.deltaTime;
        _mouseY = _mouseLook.y * camSensitivity * Time.deltaTime;
    }
}
