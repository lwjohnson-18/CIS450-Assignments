/*
 * Lucas Johnson
 * ObjectSpawnerController
 * Assignment 5
 * Controls Falling Object System
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawnerController : MonoBehaviour
{
    public GameObject[] objects;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObject", 3f, 2f);
    }

    void SpawnObject()
    {
        Instantiate(objects[Random.Range(0, objects.Length)], new Vector3(transform.position.x + Random.Range(-9, 9), transform.position.y, transform.position.z), Quaternion.identity);
    }
}
