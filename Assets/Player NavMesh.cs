using UnityEngine;
using UnityEngine.AI;

public class PlayerNavMesh : MonoBehaviour
{
    [SerializeField] private Transform moveTransformPosition; 
    [SerializeField] private float movementSpeed = 8f; // Add your desired speed here
    private NavMeshAgent navMeshAgent;

    private void Awake() 
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        if (navMeshAgent != null)
        {
            // This overrides the Inspector speed value
            navMeshAgent.speed = movementSpeed; 
            navMeshAgent.acceleration = movementSpeed * 2f; // Helps reach top speed faster
        }
        else
        {
            Debug.LogError("NavMeshAgent component is missing from this GameObject.");
        }
    }

    private void Update()
    {
        if (navMeshAgent != null && moveTransformPosition != null)
        {
            navMeshAgent.SetDestination(moveTransformPosition.position);
        }
    }
}