using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerControllerPrueba : MonoBehaviour
{
    NavMeshAgent navMeshAgent;
    [SerializeField] GameObject canvas;

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
            transform.position = new Vector3(0,0,0);
        }
        if (other.CompareTag("Obstaculo"))
        {
            navMeshAgent.destination = transform.position;
            canvas.SetActive(true);
            Time.timeScale=0;
        }
    }
}
