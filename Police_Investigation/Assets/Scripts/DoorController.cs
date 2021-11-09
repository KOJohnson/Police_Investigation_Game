using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    private BoxCollider _boxCollider;
    private void Start()
    {
        _boxCollider = GetComponent<BoxCollider>();
    }

    void Update()
    {
        if (GameManager.instance.openDoor)
        {
            _boxCollider.enabled = false;
        }  
    }
}
