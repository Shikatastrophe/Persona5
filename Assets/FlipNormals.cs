using UnityEngine;

public class FlipNormals : MonoBehaviour
{
    void Start()
    {
        SkinnedMeshRenderer skinnedMeshRenderer = GetComponent<SkinnedMeshRenderer>();
        Mesh mesh = skinnedMeshRenderer.sharedMesh;
        Vector3[] normals = mesh.normals;
        for (int i = 0; i < normals.Length; i++)
        {
            normals[i] = -normals[i];
        }
        mesh.normals = normals;

        int[] triangles = mesh.triangles;
        for (int i = 0; i < triangles.Length; i += 3)
        {
            int t = triangles[i];
            triangles[i] = triangles[i + 2];
            triangles[i + 2] = t;
        }
        mesh.triangles = triangles;

        skinnedMeshRenderer.sharedMesh = mesh;
    }
}

