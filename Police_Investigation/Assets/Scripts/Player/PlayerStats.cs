using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class PlayerStats : MonoBehaviour
{
    public static PlayerStats instance;
    public new Vector3 PlayerPosition {get; private set;}
    public float currentHealth;
    public float maxHealth = 100f;
    public HealthBar healthBar;
    
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
        currentHealth = maxHealth;
        if (healthBar != null)
        {
            healthBar.SetMaxHealth(maxHealth);
        }
    }
    
    void Update()
    {
        PlayerPosition = transform.position;
    }

    public void PlayerTakeDamage(float damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
        
        if (currentHealth <= 0)
        {
            GameManager.instance.playerDead = true;
        }
    }

    private void Die()
    {
        throw new NotImplementedException();
    }
    
    
}
