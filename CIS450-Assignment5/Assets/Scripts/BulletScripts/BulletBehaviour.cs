/*
 * Lucas Johnson
 * BulletBehaviour
 * Assignment 5
 * Handles bullet collisions
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BulletColor
{
    Red,
    Green,
    Blue
}

public abstract class BulletBehaviour : MonoBehaviour
{
    public BulletColor bulletColor;

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
