/*
 * Lucas Johnson
 * ObjectBehaviour
 * Assignment 4
 * How the falling objects should behave
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectBehaviour : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
