using System;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    //nice
    public float damage = 10f;
    public AgentController agentController;
    private void Start()
    {
        agentController = GetComponentInParent<AgentController>();
    }

    private void Update()
    {
        if (agentController.isDead)
        {
            damage = 0;
        }
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            PlayerStats.instance.PlayerTakeDamage(damage);
        }
    }
}
