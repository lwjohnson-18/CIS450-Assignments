/*
 * Lucas Johnson
 * BulletBehaviour
 * Assignment 6
 * Handles bullet collisions
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ObjectColor
{
    Red,
    Green,
    Blue
}

public abstract class BulletBehaviour : MonoBehaviour
{
    public ObjectColor bulletColor;

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
