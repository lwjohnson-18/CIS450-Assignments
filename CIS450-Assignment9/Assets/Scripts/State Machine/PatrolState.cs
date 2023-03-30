/*
 * Lucas Johnson
 * PatrolState
 * Assignment 9
 * Enemy Patrol State
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolState : MonoBehaviour, IState
{
    public Transform[] patrolPoints;
    [HideInInspector] public EnemyController enemyController;

    private int destPoint = 0;

    private void Awake()
    {
        enemyController = FindObjectOfType<EnemyController>();
    }

    public void CatchPlayer()
    {
        print("Patrol State: Catch Player");
    }

    public void PlayerInRange()
    {
        print("Patrol State: Player in Range");
    }

    public void PlayerOutOfRange()
    {
        StartCoroutine(Patrol());
    }

    public IEnumerator Patrol()
    {
        while (enemyController.currentState == enemyController.patrolState)
        {
            if (Vector3.Distance(enemyController.transform.position, enemyController.player.position) > enemyController.detectRadius)
            {
                if (!enemyController.agent.pathPending && enemyController.agent.remainingDistance < 0.5f)
                {
                    if (patrolPoints.Length != 0)
                    {
                        enemyController.agent.destination = patrolPoints[destPoint].position;

                        destPoint = (destPoint + 1) % patrolPoints.Length;
                    }
                }
            }
            else
            {
                enemyController.SetState(enemyController.chaseState);
            }
            yield return 0;
        }
        enemyController.PlayerInRange();
    }
}
