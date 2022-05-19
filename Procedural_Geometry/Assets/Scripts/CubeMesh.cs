using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(MeshFilter))]
public class CubeMesh : MonoBehaviour
{
    Mesh mesh;

    private void Awake()
    {
        mesh = new Mesh();
        mesh.name = "Cube Mesh";

        GetComponent<MeshFilter>().sharedMesh = mesh;
    }


    private void Update() => GenerateMesh();

    public void GenerateMesh()
    {
        mesh.Clear();

        List<Vector3> vertices = new List<Vector3>()
        {
            new Vector3(-1,1,-1),
            new Vector3(1,1,-1),
            new Vector3(-1,-1,-1),
            new Vector3(1,-1,-1),
            new Vector3(-1,1,1),
            new Vector3(1,1,1),
            new Vector3(-1,-1,1),
            new Vector3(1,-1,1)
        };

        List<int> trianglesList = new List<int>()
        {
            2,0,1,
            2,1,3,
            0,4,5,
            0,5,1,
            2,6,7,
            2,7,3,
            3,1,5,
            3,5,7,
            6,4,0,
            6,0,2,
            7,5,4,
            7,4,6
        };
        mesh.SetVertices(vertices);
        mesh.SetTriangles(trianglesList, 0);
    

    }

}
