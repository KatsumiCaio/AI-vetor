using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; //Colocando a biblioteca para poder usar os itens relacionados a Intelig�ncia Artificial

[RequireComponent(typeof(NavMeshAgent))]//Adicionando  os componentes necess�rios

public class EX3 : MonoBehaviour
{
    public Transform target; // variavel do tipo Transform

    private NavMeshAgent navMesh; // Inserindo o NavMeshAgent como privado

   void Start()
    {
        navMesh = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        navMesh.SetDestination(target.position); //fazendo o Obejct se movimentar ao destino alvo
    }
}
