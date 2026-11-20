using UnityEngine;
using UnityEngine.AI;

public class Enemy2D : MonoBehaviour
{
    [SerializeField] Transform player;
    NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false; // no girar en 3D
        agent.updateUpAxis = false;   // plano XY
    }

    void Update()
    {
        agent.SetDestination(player.position);
    }

}
