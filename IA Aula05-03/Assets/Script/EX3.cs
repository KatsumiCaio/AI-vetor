using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class EX3 : MonoBehaviour
{
    public Transform target;

    private NavMeshAgent navMesh;

   void Start()
    {
        navMesh = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        navMesh.SetDestination(target.position);
    }
}
