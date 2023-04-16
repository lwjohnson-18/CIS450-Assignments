/*
 * Lucas Johnson
 * ObjectSpawnerController
 * Assignment 10
 * Object Initialization Parent Class
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ObjectInitialization : MonoBehaviour
{
    public Rigidbody rb;

    public ObjectColor currentColor;

    public void InitializeObject()
    {
        InitializeMesh();
        InitializeColor();
        InitializeSpeed();
        if(HookDifficulty())
        {
            ApplyHardDifficulty();
        }
    }

    public abstract void InitializeMesh();

    public void InitializeColor()
    {
        int randomColor = Random.Range(0, 3);

        switch (randomColor)
        {
            case 0:
                currentColor = ObjectColor.Red;
                GetComponent<MeshRenderer>().material.color = Color.red;
                break;
            case 1:
                currentColor = ObjectColor.Green;
                GetComponent<MeshRenderer>().material.color = Color.green;
                break;
            case 2:
                currentColor = ObjectColor.Blue;
                GetComponent<MeshRenderer>().material.color = Color.blue;
                break;
            default:
                break;
        }
    }

    public abstract void InitializeSpeed();

    public virtual bool HookDifficulty()
    {
        return false;
    }

    public abstract void ApplyHardDifficulty();
}
