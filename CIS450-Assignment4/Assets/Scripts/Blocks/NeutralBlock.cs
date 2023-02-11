/*
 * Lucas Johnson
 * NeutralBlock
 * Assignment 4
 * Neutral Block Concrete Class
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeutralBlock : Block
{
    public void Awake()
    {
        pointValue = 0;
    }

    public override void PlayerInteraction()
    {
        if (TryGetComponent(out BlockDecorator decorator))
        {
            decorator.PlayerInteraction();
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
