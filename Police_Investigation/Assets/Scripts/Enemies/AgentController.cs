using System;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.AI;
using Debug = UnityEngine.Debug;
using Random = System.Random;

[RequireComponent(typeof(Animator),typeof(NavMeshAgent))]
public class AgentController : MonoBehaviour
{
    [SerializeField]private float health = 100f; 
    [SerializeField]public bool isDead;

    [SerializeField]private NavMeshAgent agent;
    [SerializeField]private float _distanceToPlayer;
    [SerializeField]private float attackRange;
    [SerializeField]private float speed;

   public Animator anim;
   public Transform player;
   public CapsuleCollider collider;
   
   private void Update()
   {
       bool playerDead = GameManager.instance.playerDead;
       _distanceToPlayer = Vector3.Distance(transform.position, player.position);
       
       if (_distanceToPlayer > attackRange && !isDead && !playerDead)
       {
           agent.SetDestination(player.position);
           MoveToPlayer();
       }
       else if (_distanceToPlayer <= attackRange && !isDead && !playerDead)
       {
           AttackPlayer();
       }

       if (playerDead && !isDead)
       {
           agent.speed = 0f; 
           anim.Play("Zombie Scream");
       }
   }
   
   private void MoveToPlayer()
    {
        agent.speed = speed;
        anim.Play("Zombie Running 1");
    }

    private void AttackPlayer()
    {
        agent.speed = 0f;
        anim.Play("Zombie Punch 1");
    }
    
    public void TakeDamage(float damage)
    {
        health -= damage;
        if(health <= 0)
        {
            isDead = true;
            Die();
        }
        if(isDead) GameManager.instance.enemyKilled += 1;
    }
    
    private void Die()
    {
        agent.speed = 0f;
        collider.enabled = false;
        agent.enabled = false;
        anim.Play("Zombie Death 1");
    }

}
