using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
public class SamuraiCape : MonoBehaviour
{
    Mesh capeMesh;
    private void Awake()
    {
       capeMesh  = new Mesh();
        capeMesh.name = "Cape Mesh";

        GetComponent<MeshFilter>().sharedMesh = capeMesh;
    }

    void Update() => GenerateCape();
    
        
    
    public void GenerateCape()
    {
        capeMesh.Clear();

        List<Vector3> verts = new List<Vector3>()
        {
            new Vector3(0,12,-3f), //0
            new Vector3(-2.5f,10,-1.25f), //1
            new  Vector3(0,6,-4.5f), //2
            new Vector3(2.5f,10,-1.25f) , //3
            new Vector3(0,12,-2.5f), //4
            new Vector3(-2.5f,10,-1.25f), //5
            new Vector3(2.5f,10,-1.25f), //6
            new Vector3(0,8,-4f), //7
            new Vector3(-3.5f,6,2f), //8
            new Vector3(-3,5,-2.5f), //9
            new Vector3(3,5,-2.5f), //10
            new Vector3(3.5f,6,2f),//11  // Behind Cape
            


        };

        List<int> triangles = new List<int>()
        {
           // 2,1,0,
           // 2,0,3,
            9,8,5,
            9,5,7,
            5,4,7,
           10,7,6,
           10,6,11,
           7,4,6
          
        };

        capeMesh.SetVertices(verts);
        capeMesh.SetTriangles(triangles,0);


    }
}
