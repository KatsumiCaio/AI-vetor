using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]

public class EX4 : MonoBehaviour
{
    
    int local;
    public GameObject []Point;
    private NavMeshAgent navMeshAgent;

    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        InvokeRepeating("changeLocal", 2, 4);
    }
    void changeLocal()
    {
      
        local ++;
        if (local == Point.Length)
        {
            local  = 0;
        }
        navMeshAgent.destination = Point[local].transform.position;
    }
}
