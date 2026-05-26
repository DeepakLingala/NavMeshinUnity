using UnityEngine;
using UnityEngine.AI;

public class PlayerNavMesh : MonoBehaviour
{
    [SerializeField] private Transform moveTransformPosition; // Assign in Inspector
    private NavMeshAgent navMeshAgent;
 

    private void Awake() // Correct method name
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        if (navMeshAgent == null)
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
        else
        {
            if (moveTransformPosition == null)
            {
                Debug.LogWarning("moveTransformPosition is not assigned in the Inspector.");
            }
        }
    }
}
