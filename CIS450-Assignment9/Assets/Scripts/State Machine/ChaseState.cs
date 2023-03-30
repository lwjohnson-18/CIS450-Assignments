/*
 * Lucas Johnson
 * ChaseState
 * Assignment 9
 * Enemy Chase State
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseState : MonoBehaviour, IState
{
    [HideInInspector] public EnemyController enemyController;

    private void Awake()
    {
        enemyController = FindObjectOfType<EnemyController>();
    }

    public void CatchPlayer()
    {
        print("Chase State: Catch Player");
    }

    public void PlayerInRange()
    {
        StartCoroutine(Chase());
    }

    public IEnumerator Chase()
    {
        bool caught = false;
        while (enemyController.currentState == enemyController.chaseState)
        {
            float distanceToPlayer = Vector3.Distance(enemyController.transform.position, enemyController.player.position);
            
            //OnUpdate
            if (distanceToPlayer < enemyController.detectRadius)
            {
                enemyController.agent.SetDestination(enemyController.player.position);

                if(distanceToPlayer < enemyController.catchRadius)
                {
                    enemyController.SetState(enemyController.playerCaughtState);
                    caught = true;
                }
            }
            else
            {
                enemyController.SetState(enemyController.patrolState);
            }
            yield return 0;
        }

        if (!caught)
        {
            enemyController.PlayerOutOfRange();
        }
        else
        {
            enemyController.CatchPlayer();
        }
    }

    public void PlayerOutOfRange()
    {
        print("Chase State: Player Out of Range");
    }
}
