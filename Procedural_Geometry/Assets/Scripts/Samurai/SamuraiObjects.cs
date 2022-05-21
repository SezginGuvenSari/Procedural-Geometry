using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
public class SamuraiObjects : MonoBehaviour
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
            new Vector3(0,12,-3f), //0
            new Vector3(-2.5f,10,-1.25f), //1
            new  Vector3(0,6,-6f), //2
            new Vector3(2.5f,10,-1.25f) , //3
            new Vector3(2.5f,12,0), //4
            new Vector3(2.5f,10,-1.25f), //5
            new Vector3(2.5f,10,0), //6
            new Vector3(2.5f,10,4f), //7
            new Vector3(2.5f,7,3f), //8
            new Vector3(-2.5f,12,0), //9 
            new Vector3(-2.5f,10,4f), //10
            new Vector3(-2.5f,10,0), //11
            new Vector3(-2.5f,10,-1.25f), //12
            new Vector3(-2.5f,7,3f) //13



        };

        List<int> triangles = new List<int>()
        {
             2,1,0,
             2,0,3,
             5,4,7,
             8,6,7,
             7,4,5,
             10,9,12,
             10,11,13,
             12,10,9,
             13,11,10,
             12,9,10,
             8,7,6



        };

        mesh.SetVertices(verts);
        mesh.SetTriangles(triangles, 0);

        }


}
