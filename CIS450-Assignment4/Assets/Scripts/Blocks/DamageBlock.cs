/*
 * Lucas Johnson
 * DamageBlock
 * Assignment 4
 * Damage Block Concrete Class
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageBlock : Block
{
    public void Awake()
    {
        blockColor = FindObjectOfType<ObjectSpawnerController>().objectColors[0];
        pointValue = 0;
    }

    public override void PlayerInteraction()
    {
        FindObjectOfType<PlayerController>().TakeDamage();
        Destroy(gameObject);
    }
}
