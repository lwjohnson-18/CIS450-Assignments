using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallPoints : BlockDecorator
{
    public void Awake()
    {
        blockColor = FindObjectOfType<ObjectSpawnerController>().objectColors[1];
        pointValue = 100;
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
