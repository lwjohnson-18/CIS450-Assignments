/*
 * Lucas Johnson
 * LargePoints
 * Assignment 4
 * Large Points Decorator
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LargePoints : BlockDecorator
{
    public void Awake()
    {
        blockColor = FindObjectOfType<ObjectSpawnerController>().objectColors[2];
        pointValue = 500;
    }

    public override int GetPointValue()
    {
        return wrappedBlock.pointValue + pointValue;
    }

    public override void PlayerInteraction()
    {
        FindObjectOfType<ScoreController>().UpdateScore(GetPointValue());
        Destroy(gameObject);
    }
}
