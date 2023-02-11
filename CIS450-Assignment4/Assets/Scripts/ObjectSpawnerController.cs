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
    enum BlockTypes
    {
        DamageBlock,
        NeutralBlock
    }

    enum DecoratorTypes
    {
        None,
        SmallPoints,
        LargePoints
    }

    [SerializeField] GameObject objectPrefab;
    public Material[] objectColors;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObject", 3f, 0.25f);
    }

    void SpawnObject()
    {
        GameObject newBlock = Instantiate(objectPrefab, new Vector3(transform.position.x + Random.Range(-7, 7), transform.position.y, transform.position.z), Quaternion.identity);

        int randomBlockType = Random.Range(0, 5);

        switch (randomBlockType)
        {
            case 0:
                ApplyBlockBehaviour(newBlock, BlockTypes.DamageBlock);
                break;
            case 1:
            case 2:
            case 3:
                ApplyBlockBehaviour(newBlock, BlockTypes.NeutralBlock, DecoratorTypes.SmallPoints);
                break;
            case 4:
                ApplyBlockBehaviour(newBlock, BlockTypes.NeutralBlock, DecoratorTypes.LargePoints);
                break;
            default:
                break;
        }

        
    }

    void ApplyBlockBehaviour(GameObject currentObject, BlockTypes blockType, DecoratorTypes decoratorScript = DecoratorTypes.None)
    {
        Block addedBlockScript;

        if(blockType == BlockTypes.DamageBlock)
        {
            addedBlockScript = currentObject.AddComponent<DamageBlock>();
        }
        else
        {
            addedBlockScript = currentObject.AddComponent<NeutralBlock>();
        }

        if (decoratorScript != DecoratorTypes.None)
        {
            BlockDecorator addedDecoratorScript;

            if (decoratorScript == DecoratorTypes.SmallPoints)
            {
                addedDecoratorScript = currentObject.AddComponent<SmallPoints>();
                addedDecoratorScript.wrappedBlock = addedBlockScript;
                currentObject.GetComponent<MeshRenderer>().material = addedDecoratorScript.blockColor;
            }
            else if (decoratorScript == DecoratorTypes.LargePoints)
            {
                addedDecoratorScript = currentObject.AddComponent<LargePoints>();
                addedDecoratorScript.wrappedBlock = addedBlockScript;
                currentObject.GetComponent<MeshRenderer>().material = addedDecoratorScript.blockColor;
            }
        }
        else
        {
            currentObject.GetComponent<MeshRenderer>().material = addedBlockScript.blockColor;
        }
    }
}
