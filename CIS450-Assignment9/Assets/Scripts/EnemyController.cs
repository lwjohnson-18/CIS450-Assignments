/*
 * Lucas Johnson
 * EnemyController
 * Assignment 9
 * Controls the enemy
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    [HideInInspector] public IState patrolState;
    [HideInInspector] public IState chaseState;
    [HideInInspector] public IState playerCaughtState;

    public IState currentState;
    public Transform player;
    public NavMeshAgent agent;

    public float detectRadius = 5f;
    public float catchRadius = 1f;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

        Transform stateObject = transform.Find("States");
        patrolState = stateObject.GetComponent<PatrolState>();
        chaseState = stateObject.GetComponent<ChaseState>();
        playerCaughtState = stateObject.GetComponent<PlayerCaughtState>();
    }

    private void Start()
    {
        currentState = patrolState;
        PlayerOutOfRange();
    }

    public void PlayerInRange()
    {
        currentState.PlayerInRange();
    }

    public void PlayerOutOfRange()
    {
        currentState.PlayerOutOfRange();
    }
    
    public void CatchPlayer()
    {
        currentState.CatchPlayer();
    }

    public void SetState(IState newState)
    {
        currentState = newState;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, detectRadius);

        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, catchRadius);
    }
}
