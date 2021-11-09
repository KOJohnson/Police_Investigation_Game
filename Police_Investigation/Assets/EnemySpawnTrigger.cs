using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnTrigger : MonoBehaviour
{
    [SerializeField] private GameObject enemySpawn; 
    private void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            enemySpawn.SetActive(true);
        }
    }
}
