using UnityEngine;
using UnityEngine.AI;

public class MoveCamera : MonoBehaviour
{
    NavMeshAgent agent;

    [SerializeField] Transform[] flyPoints; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if(agent. remainingDistance <= agent.stoppingDistance)
        {
            agent.SetDestination(flyPoints[Random.Range(0, flyPoints.Length)].position);
        }
    }
}
