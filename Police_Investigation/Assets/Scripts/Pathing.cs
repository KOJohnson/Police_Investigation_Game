using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Pathing : MonoBehaviour
{
    //This script takes the vector value from empty gameobjects placed in the world 
    //and then uses those vector values as destinations for the players navmesh agent to move towards
    
    // [SerializeField]private Transform pos1;
    // [SerializeField]private Transform pos2;
    // [SerializeField]private Transform pos3;

    [SerializeField] private Transform[] movePositions;
    [SerializeField] private List<Vector3> moveVectors;
    
    
    // private Vector3 _pos1V;
    // private Vector3 _pos2V;
    // private Vector3 _pos3V;
    
    //public List<Vector3> movePositions;
    
    private NavMeshAgent _agent;

    

    private void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        
        foreach (Transform movePoint in movePositions)
        {
            var movePointPosition = movePoint.transform.position;
            movePointPosition = new Vector3(movePointPosition.x, movePointPosition.y, movePointPosition.z);
            moveVectors.Add(movePointPosition);
        }
        
        // var position1 = pos1.transform.position;
        // _pos1V = new Vector3(position1.x, position1.y, position1.z);
        //
        // var position2 = pos2.transform.position;
        // _pos2V = new Vector3(position2.x, position2.y, position2.z);
        //
        // var position3 = pos3.transform.position;
        // _pos3V = new Vector3(position3.x, position3.y, position3.z);
        
        // movePositions.Add(_pos1V);
        // movePositions.Add(_pos2V);
        // movePositions.Add(_pos3V);
    }

    private void Update()
    {
        
        switch (GameManager.instance.enemyKilled)
        {
            case 3:
                _agent.SetDestination(moveVectors[0]);
                break;
            case 6:
                _agent.SetDestination(moveVectors[1]);
                break;
            case 9:
                _agent.SetDestination(moveVectors[2]);
                break;
            case 12:
                _agent.SetDestination(moveVectors[3]);
                break;
            case 13:
                _agent.SetDestination(moveVectors[4]);
                break;
        }
    }
}
