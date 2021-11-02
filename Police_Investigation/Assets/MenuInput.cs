using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuInput : MonoBehaviour
{
    private Camera camera;
    public LayerMask isClickable;

    private void Awake()
    {
        camera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
       

       // if (CustomPlayerInputManager.instance.leftMousePressed)
        //{
            Vector2 mousePos = Input.mousePosition;
            Ray ray = camera.ScreenPointToRay(mousePos);
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                Debug.DrawRay(ray.origin, ray.direction * 10, Color.red);
                Debug.Log(hit.point);
            }
        //}
        
    }
}
