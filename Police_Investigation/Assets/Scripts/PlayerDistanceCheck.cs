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
            }
        }
        else
        {
            visualCue.SetActive(false);
        }

    }
}
