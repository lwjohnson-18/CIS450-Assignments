/*
 * Lucas Johnson
 * ObjectBehaviour
 * Assignment 6
 * How the falling objects should behave
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectBehaviour : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ground") || collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<BulletBehaviour>().bulletColor.Equals(GetComponent<ObjectInitialization>().currentColor))
        {
            Destroy(gameObject);
        }
    }
}
