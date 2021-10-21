using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public static PlayerStats instance;
    public new Vector3 PlayerPosition {get; private set;}

    public int playerHealth;
    public int cunning;
    public int intimidate;
    
    // //move all this to an NPC scriptable object
    // public string enemyState;
    //
    // //move all this to an NPC scriptable object
    // public enum States
    // {
    //     Idle,
    //     Wandering,
    //     Attack
    // }
    //
    // public States states;
    
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
    
    void Start()
    {
        playerHealth = 100;
        
    }
    
    void Update()
    {
        PlayerPosition = transform.position;
        
    }
    
    // //move all this to an NPC scriptable object
    // public void StateHandling()
    // {
    //     switch (states)
    //     {
    //         case States.Idle:
    //             Debug.Log("Switched Successfully now idling");
    //             break;
    //         
    //         case States.Wandering:
    //             Debug.Log("Switched Successfully now wandering");
    //             break;
    //         
    //         case States.Attack:
    //             Debug.Log("Switched Successfully now attacking");
    //             break;
    //     }
    // }
    
}
