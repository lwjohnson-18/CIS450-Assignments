/*
 * Lucas Johnson
 * BulletBehaviour
 * Assignment 5
 * Handles bullet collisions
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
