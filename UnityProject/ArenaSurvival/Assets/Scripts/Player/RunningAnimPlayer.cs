using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RunningAnimPlayer : MonoBehaviour {

    Animator anim;
    NavMeshAgent agent;
    Animation animStat;


    private bool animRunning = false;
    public float animSpeed = 0.25f;

	void Start () {
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponentInChildren<Animator>();
        
    }

	void Update () {

        if(agent.remainingDistance <= agent.stoppingDistance)
        {
            animRunning = false;
        }
        else
        {
            animRunning = true;
        }

        anim.SetBool("isRunning", animRunning);

        //animStat["FUCM_0012b_EH_RUN_LP_NoZ"].speed = animSpeed;




    }
}
