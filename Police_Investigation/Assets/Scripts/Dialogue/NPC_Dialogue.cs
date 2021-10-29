using System;
using System.Collections;
using System.Collections.Generic;
using Player;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NPC_Dialogue : MonoBehaviour
{
    public NPC_States npcStates;
    public BartenderStates bState;
    public NPC_Data npcData;
    
    public GameObject visualCue;

    private int Bouncer;
    private int Cleaner;
    private int Bartender;
    private int Boss;
    
    private void Awake()
    {
        Bouncer = 1;
        Bartender = 2;
        Cleaner = 3;
        Boss = 4;
        
        npcData.playerInRange = false; 
        visualCue.SetActive(false);
    }
    
    void Update()
    {
        //returns distance between two vectors 
        float distanceToPlayer = Vector3.Distance(transform.position, PlayerStats.instance.PlayerPosition);
        
        if (distanceToPlayer <=  npcData.maxRange)
        {
            npcData.playerInRange = true;
        }

        if (distanceToPlayer >  npcData.maxRange)
        {
            npcData.playerInRange = false;
        }

        if ( npcData.playerInRange && !DialogueManager.instance.dialogueIsPlaying)
        {
            //turn on visual cue to let player now that this object can be interacted with 
            visualCue.SetActive(true);
            
            if (CustomPlayerInputManager.instance.fPressed)
            {
                //Enter dialogue mode               //using text asset from each NPC Data
                DialogueManager.instance.EnterDialogueMode(npcData.inkJSON);
                
                //check if var match unique index from NPC Data
                //could probably use switch switch statement 
                if (Cleaner == npcData.Index)
                {
                    Debug.Log("Cleaner Working!!!");
                    npcStates.KeyCheck();
                }
                if (Bouncer == npcData.Index)
                {
                    //DO SOMETHING
                    Debug.Log("Bouncer Working!!!");
                }
                if (Bartender == npcData.Index)
                {
                    //DO SOMETHING
                    bState.Whiskey();
                    if (bState.isDrunk)
                    {
                        // SceneManager.LoadScene(1);
                        Debug.Log("Bartender Working!!!");
                    }
                }
                if (Boss == npcData.Index)
                {
                    //DO SOMETHING
                    Debug.Log("Boss Working!!!");
                }
            }
        }
        else
        {
            visualCue.SetActive(false);
        }

    }
}