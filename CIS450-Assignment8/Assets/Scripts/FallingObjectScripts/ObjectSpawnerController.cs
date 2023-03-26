/*
 * Lucas Johnson
 * ObjectSpawnerController
 * Assignment 6
 * Controls Falling Object System
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawnerController : MonoBehaviour
{
    public GameObject objectPrefab;

    public Mesh blockMesh;
    public Mesh sphereMesh;

    public bool hardMode;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObject", 3f, 2f);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.H))
        {
            hardMode = !hardMode;
        }
    }

    void SpawnObject()
    {
        GameObject spawnedObject = Instantiate(objectPrefab, new Vector3(transform.position.x + Random.Range(-9, 9), transform.position.y, transform.position.z), Quaternion.identity);
        
        ObjectInitialization objectInitialization;
        
        int randomShape = Random.Range(0, 2);
        if(randomShape == 0)
        {
            objectInitialization = spawnedObject.AddComponent<BlockInitialization>();
        }
        else
        {
            objectInitialization = spawnedObject.AddComponent<SphereInitialization>();
        }
        
        objectInitialization.spawnerRefrence = this;
        objectInitialization.InitializeObject();
    }
}
