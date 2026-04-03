using System.Collections;
using UnityEngine;

public class ModelStats : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(CalculateStats());
    }

    private IEnumerator CalculateStats()
    {
        var loader = GetComponent<ModelLoader>();

        while (loader == null || !loader.Finish)
        {
            yield return null;
        }

        MeshFilter[] meshFilters = GetComponentsInChildren<MeshFilter>();
        SkinnedMeshRenderer[] skinnedMeshes = GetComponentsInChildren<SkinnedMeshRenderer>();

        int vertexCount = 0;

        // MeshFilter
        foreach (var mf in meshFilters)
        {
            if (mf.sharedMesh != null)
                vertexCount += mf.sharedMesh.vertexCount;
        }

        // SkinnedMeshRenderer
        foreach (var sm in skinnedMeshes)
        {
            if (sm.sharedMesh != null)
                vertexCount += sm.sharedMesh.vertexCount;
        }

        Debug.Log("Total Vertices: " + vertexCount);
    }
}