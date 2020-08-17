using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;



public class EnemySmallBrain : MonoBehaviour
{

    GameObject Player;
    NavMeshAgent EAgent;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        EAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        EAgent.SetDestination(Player.transform.position);
    }
}
