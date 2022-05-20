using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriangularPrism : MonoBehaviour
{
    private void Awake() => MeshCreator();
    
       
    public void MeshCreator()
    {
        Mesh mesh = new Mesh();
        mesh.name = "Triangular Prism";


        List<Vector3> vertPoints = new List<Vector3>()
        {
            new Vector3(-1,1),
            new Vector3(1,1),
            new Vector3(-1,-1),
            new Vector3(1,-1),
            new Vector3(0,0,-2)
        };

        int[] triIndices = new int[]
        {
            2,0,1,
            2,1,3,
            2,0,4,
            0,1,4,
            2,4,3,
            1,3,4

        };

        mesh.SetVertices(vertPoints);
        mesh.triangles = triIndices;

        GetComponent<MeshFilter>().sharedMesh = mesh;
    }
}