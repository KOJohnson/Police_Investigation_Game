using System;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(Animator),typeof(NavMeshAgent))]
public class AgentController : MonoBehaviour
{

   public Transform player;
   [SerializeField]private NavMeshAgent agent;
   
   private float _distanceToPlayer;
   [SerializeField]private float attackRange;
   [SerializeField]private float speed;

   public Animator anim;

   private void Awake()
   {
       
   }

   void Update()
   {
       _distanceToPlayer = Vector3.Distance(transform.position, player.position);
       
       if (_distanceToPlayer > attackRange)
       {
           agent.SetDestination(player.position);
           MoveToPlayer();
       }
       else if (_distanceToPlayer <= attackRange)
       {
           AttackPlayer();
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

}
