using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class FlashLightController : MonoBehaviour
{
    [SerializeField] private new GameObject light;
    [SerializeField] private bool lightOn;
    private void Start()
    {
        lightOn = true;
    }
    void Update()
    {
        if (CustomPlayerInputManager.instance.hPressed && lightOn)
        {
            light.SetActive(false);
            lightOn = false;
        }
        else if (CustomPlayerInputManager.instance.hPressed && !lightOn)
        {
            light.SetActive(true);
            lightOn = true;
        }
    }
}
