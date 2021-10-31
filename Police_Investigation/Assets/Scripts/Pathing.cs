using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Pathing : MonoBehaviour
{
    //This script takes the vector value from empty gameobjects placed in the world 
    //and then uses those vector values as destinations for the players navmesh agent to move towards
    
    [SerializeField]private Transform pos1;
    [SerializeField]private Transform pos2;
    [SerializeField]private Transform pos3;
    
    private Vector3 _pos1V;
    private Vector3 _pos2V;
    private Vector3 _pos3V;
    
    //public List<Vector3> movePositions;
    
    private NavMeshAgent _agent;

    public int enemyKilled;

    private void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        
        var position1 = pos1.transform.position;
        _pos1V = new Vector3(position1.x, position1.y, position1.z);
        
        var position2 = pos2.transform.position;
        _pos2V = new Vector3(position2.x, position2.y, position2.z);
        
        var position3 = pos3.transform.position;
        _pos3V = new Vector3(position3.x, position3.y, position3.z);
        
        // movePositions.Add(_pos1V);
        // movePositions.Add(_pos2V);
        // movePositions.Add(_pos3V);
    }

    private void Update()
    {
        switch (enemyKilled)
        {
            case 5:
                _agent.SetDestination(_pos1V);
                break;
            case 10:
                _agent.SetDestination(_pos2V);
                break;
            case 20:
                _agent.SetDestination(_pos3V);
                break;
        }
    }
}
