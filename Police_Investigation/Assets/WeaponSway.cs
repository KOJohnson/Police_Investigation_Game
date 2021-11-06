using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSway : MonoBehaviour
{
    [SerializeField] private float smooth;
    [SerializeField] private float swayMultiplier;
    private float _mouseX;
    private float _mouseY;

    // Update is called once per frame
    void Update()
    {
        _mouseX = Input.GetAxisRaw("Mouse X") * swayMultiplier;
        _mouseY = Input.GetAxisRaw("Mouse Y") * swayMultiplier;

        Quaternion rotationX = Quaternion.AngleAxis(-_mouseY, Vector3.right);
        Quaternion rotationY = Quaternion.AngleAxis(_mouseX, Vector3.up);

        Quaternion targetRotation = rotationX * rotationY;
        
        transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation, smooth *Time.deltaTime);
    }
}
