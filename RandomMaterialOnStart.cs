using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMaterialOnStart : MonoBehaviour
{
    public Material[] Materials;
    public MeshRenderer meshRenderer;

    private void Start()
    {
        var randomMaterial = Materials[Random.Range(0, Materials.Length)];
        if (randomMaterial != null) meshRenderer.material = randomMaterial;
    }
}
