using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoreObject : MonoBehaviour
{
    public List<Mesh> Meshes = new List<Mesh>();
    public int CurrentMesh;

    private MeshRenderer _meshRenderer;
    private MeshFilter _meshFilter;

    private void Start()
    {
        _meshFilter = GetComponent<MeshFilter>();
        _meshRenderer = GetComponent<MeshRenderer>();

        _meshFilter.mesh = Meshes[0];
        _meshRenderer.material.color = Color.white;
        CurrentMesh = 0;
    }

    public void SetShape(int newIndex)
    {
        CurrentMesh = newIndex;
        _meshFilter.mesh = Meshes[CurrentMesh];
    }

    public void ChangeShape()
    {
        if(CurrentMesh < Meshes.Count - 1)
        {
            CurrentMesh++;
        }
        else
        {
            CurrentMesh = 0;
        }

        _meshFilter.mesh = Meshes[CurrentMesh];
    }

    public void SetColor(Color newColor)
    {
        _meshRenderer.material.color = newColor;
    }

    public void SetRandomColor()
    {
        Color randomColor = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
        _meshRenderer.material.color = randomColor;
    }
}
