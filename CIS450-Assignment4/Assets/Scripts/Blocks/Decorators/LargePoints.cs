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
    public Block wrappedBlock;
    public int pointValue;

    public override void ApplyBehaviour()
    {
        pointValue = 100;
    }

    public override void PlayerInteraction()
    {

    }
}
