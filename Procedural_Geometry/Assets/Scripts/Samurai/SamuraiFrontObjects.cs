using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(MeshFilter))]
public class SamuraiFrontObjects : MonoBehaviour
{

    Mesh mesh;
    private void Awake()
    {
        mesh = new Mesh();
        mesh.name = "Object";

        GetComponent<MeshFilter>().sharedMesh = mesh;
    }



    void Update() => MeshObject();

    public void MeshObject()
    {
        mesh.Clear();


        List<Vector3> verts = new List<Vector3>()
        {
            new Vector3(0,12,2.5f), //0
            new Vector3(-1.5f,10,1.5f), //1
            new  Vector3(0,6,4.5f), //2
            new Vector3(1.5f,10,1.5f) , //3
            
        };

        List<int> triangles = new List<int>()
        {
             0,1,2,
             3,0,2,


        };

        mesh.SetVertices(verts);
        mesh.SetTriangles(triangles, 0);

    }
}
