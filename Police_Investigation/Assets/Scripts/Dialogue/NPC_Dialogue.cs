using System;
using System.Collections;
using System.Collections.Generic;
using Player;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NPC_Dialogue : MonoBehaviour
{
    public NPC_States npcStates;
    public BartenderStates bartender;
    public IsabelObserver iObserver;
    public BouncerObserver bObserver;
    public NPC_Data npcData;
    
    public GameObject visualCue;

    private int Bouncer;
    private int Cleaner;
    private int Bartender;
    private int Boss;
    private int Isabel;
    private int Agent;
    
    private void Awake()
    {
        Bouncer = 1;
        Bartender = 2;
        Cleaner = 3;
        Boss = 4;
        Isabel = 5;
        Agent = 6;
        
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

        if (npcData.playerInRange && !DialogueManager.instance.dialogueIsPlaying)
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
                    npcStates.KeyCheck();
                }
                if (Bouncer == npcData.Index)
                {
                    //DO SOMETHING
                    bObserver.OpenDoor();
                }
                if (Bartender == npcData.Index)
                {
                    //DO SOMETHING
                    bartender.Whiskey();
                }
                if (Boss == npcData.Index)
                {
                    //DO SOMETHING
                }
                if (Isabel == npcData.Index)
                {
                    iObserver.HasGirl();
                }
            }
        }
        else
        {
            visualCue.SetActive(false);
        }

    }
}
