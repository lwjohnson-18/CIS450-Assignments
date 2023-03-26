using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockInitialization : ObjectInitialization
{
    public override void InitializeMesh()
    {
        GetComponent<MeshFilter>().mesh = spawnerRefrence.blockMesh;
    }

    public override void InitializeSpeed()
    {
        rb = GetComponent<Rigidbody>();
        rb.drag = 7;
    }

    public override bool HookDifficulty()
    {
        return spawnerRefrence.hardMode;
    }

    public override void ApplyHardDifficulty()
    {
        rb.drag /= 2;
    }
}
