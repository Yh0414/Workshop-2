using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]

public class GeneratePyramid : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        var meshFilter = GetComponent<MeshFilter>();
        meshFilter.mesh = CreateMesh();
    }

    private Mesh CreateMesh()
    {
        var mesh = new Mesh
        {
            name = "Pyramid"
        };

        mesh.SetVertices(new[]
        {
            // Bottom face
            new Vector3(-1.0f, -1.0f, -1.0f),
            new Vector3(1.0f, -1.0f, 1.0f),
            new Vector3(-1.0f, -1.0f, 1.0f),

            new Vector3(-1.0f, -1.0f, -1.0f),
            new Vector3(1.0f, -1.0f, -1.0f),
            new Vector3(1.0f, -1.0f, 1.0f),

            // Font face
            new Vector3(-1.0f, -1.0f, -1.0f),
            new Vector3(0, 1.0f, 0),
            new Vector3(1.0f, -1.0f, -1.0f),

            // Back face
            new Vector3(1.0f, -1.0f, 1.0f),
            new Vector3(0, 1.0f, 0),
            new Vector3(-1.0f, -1.0f, 1.0f),

            // Left face
            new Vector3(-1.0f, -1.0f, 1.0f),
            new Vector3(0, 1.0f, 0),
            new Vector3(-1.0f, -1.0f, -1.0f),

            // Right face
            new Vector3(1.0f, -1.0f, -1.0f),
            new Vector3(0, 1.0f, 0),
            new Vector3(1.0f, -1.0f, 1.0f)


        });

        mesh.SetColors(new[]
        {
            // Bottom face
            Color.red,
            Color.red,
            Color.red,

            Color.red,
            Color.red,
            Color.red,

            // Font face
            Color.yellow,
            Color.yellow,
            Color.yellow,

            // Back face
            Color.green,
            Color.green,
            Color.green,

            // Left face
            Color.gray,
            Color.gray,
            Color.gray,

            // Right face
            Color.blue,
            Color.blue,
            Color.blue

        });

        var indices = Enumerable.Range(0, mesh.vertices.Length).ToArray();
        mesh.SetIndices(indices, MeshTopology.Triangles, 0);

        return mesh;
    }
}
