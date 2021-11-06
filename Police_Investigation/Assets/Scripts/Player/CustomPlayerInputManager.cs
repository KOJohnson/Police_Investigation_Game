using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomPlayerInputManager : MonoBehaviour
{
    public static CustomPlayerInputManager instance = null;
    
    //input bools
    public bool wPressed;
    public bool aPressed;
    public bool sPressed;
    public bool dPressed;
    public bool fPressed;
    public bool rPressed;
    public bool leftShiftPressed;
    public bool leftMousePressed;
    public bool leftMouseReleased;
    public bool spacebarPressed;
    
    //flashlight
    public bool hPressed;
    
    //camera settings
    public float mouseX;
    public float mouseY;
    public float CamSens = 50;
    private void Awake()
    {
        if (instance == null) //check if instance is null
        {
            instance = this; // assign instance to this instance of the class
        }
        else if (instance != this) //check if this instance has already been assigned elsewhere
        {
            Destroy(gameObject); //destroy manager if one already exists in the scene
        }
    }

    private void Start()
    {
        wPressed = false;
        aPressed = false;
        sPressed = false;
        dPressed = false;
        fPressed = false;
        hPressed = false;
        rPressed = false;
        leftShiftPressed = false;
        leftMousePressed = false;
    }


    // Update is called once per frame
    void Update()
    {
        //movement input
        wPressed = Input.GetKey(KeyCode.W);
        aPressed = Input.GetKey(KeyCode.A);
        sPressed = Input.GetKey(KeyCode.S);
        dPressed = Input.GetKey(KeyCode.D);
        leftShiftPressed = Input.GetKey(KeyCode.LeftShift);

        //Weapon Input
        leftMousePressed = Input.GetButtonDown("Fire1");
        leftMouseReleased = Input.GetButtonUp("Fire1");
        rPressed = Input.GetKeyDown(KeyCode.R);
        
        //Camera Input
        mouseX = Input.GetAxisRaw("Mouse X") * CamSens * Time.deltaTime;
        mouseY = Input.GetAxisRaw("Mouse Y") * CamSens * Time.deltaTime;
        
        //interact input
        fPressed = Input.GetKeyDown(KeyCode.F);
        spacebarPressed = Input.GetKeyDown(KeyCode.Space);
        
        //Toggle Flashlight 
        hPressed = Input.GetKeyDown(KeyCode.H);
    }
    
}
