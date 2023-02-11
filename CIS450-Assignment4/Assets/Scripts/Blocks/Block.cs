/*
 * Lucas Johnson
 * Block
 * Assignment 4
 * Block Abstract Class
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Block : MonoBehaviour
{
    public Material blockColor;
    public int pointValue;

    public int GetPointValue()
    {
        return pointValue;
    }

    public abstract void PlayerInteraction();
}
