using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDistanceCheck : MonoBehaviour
{
    public Movement _movement;
    public GameObject player;
    public GameObject visualCue;
    private float maxRange = 5f;
    [SerializeField] bool playerInRange;
    
    [Header("Ink JSON")]
    [SerializeField ]private  TextAsset inkJSON;

    private string idle = "Idle";

    private void Awake()
    {
        playerInRange = false;
        visualCue.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //returns distance between two vectors 
        float distanceToPlayer = Vector3.Distance(transform.position, PlayerStats.instance.PlayerPosition);
        
        if (distanceToPlayer <= maxRange)
        {
            playerInRange = true;
        }

        if (distanceToPlayer > maxRange)
        {
            playerInRange = false;
        }

        if (playerInRange && !DialogueManager.instance.dialogueIsPlaying)
        {
            visualCue.SetActive(true);
            if (CustomPlayerInputManager.instance.fPressed)
            {
                DialogueManager.instance.EnterDialogueMode(inkJSON);
                
                //get and set current state
                PlayerStats.instance.enemyState = (string) DialogueManager.instance.currentStory.variablesState["state"];
                //Debug.Log($"Checking story variable state: {PlayerStats.instance.enemyState}");
                //set state
                PlayerStats.instance.states = PlayerStats.States.Idle;
                PlayerStats.instance.StateHandling();

                //check if state changed during dialogue 
                DialogueManager.instance.currentStory.ObserveVariable("state", (arg, value) =>
                {
                    PlayerStats.instance.enemyState = (string)DialogueManager.instance.currentStory.variablesState["state"];
                    //Debug.Log($"Value updated. Enemy state: {value}");
                    PlayerStats.instance.states = PlayerStats.States.Attack;
                    PlayerStats.instance.StateHandling();
                });
                
            }
        }
        else
        {
            visualCue.SetActive(false);
        }

    }
}