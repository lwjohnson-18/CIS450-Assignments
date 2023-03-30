/*
 * Lucas Johnson
 * CatchPlayerState
 * Assignment 9
 * Enemy Catch Player State
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCaughtState : MonoBehaviour, IState
{
    [HideInInspector] public EnemyController enemyController;
    public GameObject gameOverText;
    private void Awake()
    {
        enemyController = FindObjectOfType<EnemyController>();
    }

    public void CatchPlayer()
    {
        gameOverText.SetActive(true);
    }

    public void PlayerInRange()
    {
        print("Player Caught State: Player In Range");
    }

    public void PlayerOutOfRange()
    {
        print("Player Caught State: Player Out of Range");
    }
}
