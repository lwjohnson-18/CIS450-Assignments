/*
 * Lucas Johnson
 * ObjectSpawnerController
 * Assignment 10
 * Singleton that controls the falling object system using object pooling
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawnerController : MonoBehaviour
{
    public static ObjectSpawnerController Instance;

    [System.Serializable]
    public class Pool
    {
        public string tag;
        public GameObject prefab;
        public int size;
    }
    public List<Pool> pools = new List<Pool>();

    public List<Queue<GameObject>> poolList = new List<Queue<GameObject>>();

    public Mesh blockMesh;
    public Mesh sphereMesh;

    public bool hardMode;

    private void Awake()
    {
        Instance = this;
    }

    public 

    // Start is called before the first frame update
    void Start()
    {
        CreatePools();

        InvokeRepeating("SpawnObject", 3f, 2f);
    }

    public void CreatePools()
    {
        foreach (Pool pool in pools)
        {
            Queue<GameObject> objectPool = new Queue<GameObject>();

            for (int i = 0; i < pool.size; i++)
            {
                GameObject obj = Instantiate(pool.prefab);
                obj.SetActive(false);

                int randomShape = Random.Range(0, 2);
                if (randomShape == 0)
                {
                    obj.AddComponent<BlockInitialization>();
                }
                else
                {
                    obj.AddComponent<SphereInitialization>();
                }

                objectPool.Enqueue(obj);
            }

            poolList.Add(objectPool);
        }
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
        Queue<GameObject> randomPool = poolList[Random.Range(0, poolList.Count)];
        GameObject objectToSpawn = randomPool.Dequeue();
        objectToSpawn.SetActive(true);
        objectToSpawn.transform.position = new Vector3(transform.position.x + Random.Range(-9, 9), transform.position.y, transform.position.z);
        objectToSpawn.GetComponent<ObjectInitialization>().InitializeObject();
        randomPool.Enqueue(objectToSpawn);
    }
}
