using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(MeshFilter))]
public class Samurai : MonoBehaviour
{
    Mesh mesh;
    private void Awake()
    {
        mesh = new Mesh();
        mesh.name = "Samurai";

        GetComponent<MeshFilter>().sharedMesh = mesh;
    }


    void Update() => GenerateSamurai();


    public void GenerateSamurai()
    {
        mesh.Clear();
        
        List<Vector3> vertices = new List<Vector3>()
        {
            new Vector3(-2,0,1), //0
            new Vector3(-1,0,1), //1
            new Vector3(-2,0,0), //2
            new Vector3(-1,0,0), //3
            new Vector3(-1,-3,0),//4
            new  Vector3(1,0,1), //5
            new Vector3(2,0,1),  //6
            new Vector3(1,0,0), //7
            new Vector3(2,0,0), //8
            new Vector3(1,-3,0),  //9
          

        };

        List<int> triangles = new List<int>()
        {
            2,0,1,
            2,1,3,
            2,0,4,
            0,1,4,
            2,4,3,
            1,3,4,  // First
            7,5,6,
            7,6,8,
            7,5,9,
            5,6,9,
            6,8,9,
            8,7,9,  // Second
          
        };

        mesh.SetVertices(vertices);
        mesh.SetTriangles(triangles, 0);
    }


}
