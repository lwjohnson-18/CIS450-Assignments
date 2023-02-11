using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallPoints : BlockDecorator
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
