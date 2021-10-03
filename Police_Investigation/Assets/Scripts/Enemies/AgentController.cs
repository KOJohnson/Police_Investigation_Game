using UnityEngine;
using UnityEngine.AI;

public class AgentController : MonoBehaviour
{

   public Transform Player;

    void Update()
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.destination = Player.position;
    }

}
