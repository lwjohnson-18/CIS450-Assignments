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
    Block blockScript;

    private void Start()
    {
        blockScript = GetComponent<Block>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            blockScript.PlayerInteraction();
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
