using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public static PlayerStats instance;
    public new Vector3 PlayerPosition {get; private set;}

    public int playerHealth;
    
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
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPosition = transform.position;
    }
}
