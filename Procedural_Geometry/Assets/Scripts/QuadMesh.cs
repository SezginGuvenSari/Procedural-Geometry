using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuadMesh : MonoBehaviour
{
    private void Awake()
    {
        Mesh mesh = new Mesh();
        mesh.name = "Procedural Quad Mesh";


        List<Vector3> vertPoints = new List<Vector3>()
        {
            new Vector3(-1,1),
            new Vector3(1,1),
            new Vector3(-1,-1),
            new Vector3(1,-1)
        };

        int[] triIndices = new int[]
        {
            2,0,1,
            2,1,3

           
        };


        List<Vector3> normals = new List<Vector3>()
        {
            new Vector3(0,0,1),
            new Vector3(0,0,1),
            new Vector3(0,0,1),
            new Vector3(0,0,1)
        };

        mesh.SetVertices(vertPoints);
        mesh.SetNormals(normals);
        mesh.triangles = triIndices;

        GetComponent<MeshFilter>().sharedMesh=mesh;

    }
}
