using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;



public class EnemySmallBrain : MonoBehaviour
{
    GameObject Glowstick;
    GameObject Player;
    NavMeshAgent EAgent;
    bool GlowstickExists = false;
    bool ChasePlayer = true;
    bool Cooldown = false;

    // Start is called before the first frame update
    void Start()
    {
        Glowstick = GameObject.FindGameObjectWithTag("Glowstick");
        Player = GameObject.FindGameObjectWithTag("Player");
        EAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {

    //   // if (Input.GetKeyDown(KeyCode.Q)) {

            //        Glowstick.SetActive(true);


            //    }

            //    if (Glowstick.activeSelf && GlowstickExists == false)
            //    {
            //        EAgent.SetDestination(Glowstick.transform.position);
            //        GlowstickExists = true;
            //        ChasePlayer = false;
            //        Invoke("glowlife", 10f);
            //    }

        //else if (ChasePlayer == true)
        //{
           //EAgent.SetDestination(Player.transform.position);
        //}


        if (Cooldown == false) { EAgent.SetDestination(Player.transform.position);}

        }

        void glowlife() {

        ChasePlayer = true;

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player")&& Cooldown == false)
        {
            Cooldown = true;
            Player.GetComponent<PlayerMovement>().playerHP-=1;
            Invoke("AttackCooldown",  1.5f);
            EAgent.isStopped = true;
        }
    }

    void AttackCooldown()
    {

        Cooldown = false;
        EAgent.isStopped = false;
    }


    

}


