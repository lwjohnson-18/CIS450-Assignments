/*
 * Lucas Johnson
 * ObjectSpawnerController
 * Assignment 10
 * Initializes Sphere Object
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereInitialization : ObjectInitialization
{
    public override void InitializeMesh()
    {
        GetComponent<MeshFilter>().mesh = ObjectSpawnerController.Instance.sphereMesh;
    }

    public override void InitializeSpeed()
    {
        rb = GetComponent<Rigidbody>();
        rb.drag = 5;
    }

    public override bool HookDifficulty()
    {
        return ObjectSpawnerController.Instance.hardMode;
    }

    public override void ApplyHardDifficulty()
    {
        rb.drag /= 2;
    }
}
