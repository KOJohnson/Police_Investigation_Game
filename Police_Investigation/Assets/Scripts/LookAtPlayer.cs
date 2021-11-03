using Player;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{
    //The purpose of this script is to rotate the NPC towards a given target(the player) when in range
    //and snap back smoothly when target is out of range
    
    [SerializeField]private NPC_Data Data;
    // look target
    [SerializeField]private Transform player;
    // speed to look at target
    [SerializeField] private float rotSpeed;

    private Quaternion startRotation;

    private void Start()
    {
        startRotation = transform.rotation;
    }

    void Update()
    {
        Vector3 targetDirectiion = transform.position - player.position;
        
        float singleStep = rotSpeed * Time.deltaTime;
        
        // rotate forward towards a given target at a x speed 
        Vector3 newDirection = Vector3.RotateTowards(transform.forward, targetDirectiion, singleStep, 0.0f);

        if (Data.playerInRange)
        {
            Debug.DrawRay(transform.position, -newDirection, Color.red);
            // set rotation to look towards newDirection 
            transform.rotation = Quaternion.LookRotation(newDirection);
        }
        // if player is not in range, Lerp rotation using current rotation and start rotation 
        else transform.rotation = Quaternion.Slerp(transform.rotation, startRotation, singleStep);


    }
}
