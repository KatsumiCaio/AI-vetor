using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; //Colocando a biblioteca para poder usar os itens relacionados a Inteligência Artificial

[RequireComponent(typeof(NavMeshAgent))] //Adicionando  os componentes necessários

public class EX4 : MonoBehaviour
{
    
    int local; // declarando uma variavel do tipo Int
    public GameObject []Point; // Deixando como publico os pontos para serem escolhidos na Unity para a movimentação
    private NavMeshAgent navMeshAgent; // Inserindo o NavMeshAgent como privado e nomeando ele

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
