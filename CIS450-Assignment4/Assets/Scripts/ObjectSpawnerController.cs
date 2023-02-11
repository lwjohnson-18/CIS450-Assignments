/*
 * Lucas Johnson
 * ObjectSpawnerController
 * Assignment 4
 * Controls Falling Object System
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawnerController : MonoBehaviour
{
    [SerializeField] GameObject objectPrefab;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObject", 3f, 0.25f);
    }

    void SpawnObject()
    {
        Instantiate(objectPrefab, new Vector3(transform.position.x + Random.Range(-7, 7), transform.position.y, transform.position.z), Quaternion.identity);
    }
}
