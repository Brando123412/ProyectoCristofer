using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerControllerPrueba : MonoBehaviour
{
    NavMeshAgent navMeshAgent;

    void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 targetPosition = GetValidTargetPosition();
            if (targetPosition != Vector3.zero)
            {
                navMeshAgent.destination = targetPosition;
            }
        }
    }

    Vector3 GetValidTargetPosition()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            NavMeshHit navMeshHit;
            if (NavMesh.SamplePosition(hit.point, out navMeshHit, 1.0f, NavMesh.AllAreas))
            {
                return navMeshHit.position;
            }
        }
        return transform.position;
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Puerta")){
            print("xd");
            transform.position = new Vector3(0,0,0);
        }
    }
}
