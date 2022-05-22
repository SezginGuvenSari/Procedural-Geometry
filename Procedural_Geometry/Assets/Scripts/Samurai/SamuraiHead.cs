using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
public class SamuraiHead : MonoBehaviour
{
    Mesh mesh;
   
    private void Awake()
    {
        mesh = new Mesh();
        mesh.name = "Samurai Head";
      
        GetComponent<MeshFilter>().sharedMesh = mesh;
    }


    void Update() => GenerateHead();


    

    public void GenerateHead()       
    {
      
        List<Vector3> verts = new List<Vector3>()
        {
            new Vector3(0,14,0),  //0
            new Vector3(-2f,10,0), //1
            new Vector3(2f,10,0),  //2
            new Vector3(0,14,-2.5f)  //3
        };

        List<int> triangles = new List<int>()
        {
            1,3,2,
            1,0,3,
            2,3,0,
            0,1,3,
            0,3,2,
            3,1,2
        };


        mesh.SetVertices(verts);
        mesh.SetTriangles(triangles, 0);

    }


    private void OnDrawGizmos()
    {
        //First Cube Line
        Gizmos.DrawLine(new Vector3(3, 0, 0), new Vector3(4, 0, 0));
        Gizmos.DrawLine(new Vector3(3, 0, 0), new Vector3(3, 1, 0));
        Gizmos.DrawLine(new Vector3(4, 0, 0), new Vector3(4, 1, 0));
        Gizmos.DrawLine(new Vector3(3, 1, 0), new Vector3(4, 1, 0));
        Gizmos.DrawLine(new Vector3(4, 0, 0), new Vector3(4, 0, 1));
        Gizmos.DrawLine(new Vector3(3, 0, 0), new Vector3(3, 0, 1));
        Gizmos.DrawLine(new Vector3(4, 0, 1), new Vector3(4, 1, 1));
        Gizmos.DrawLine(new Vector3(3, 0, 1), new Vector3(3, 1, 1));
        Gizmos.DrawLine(new Vector3(3, 0, 1), new Vector3(4, 0, 1));
        Gizmos.DrawLine(new Vector3(3, 1, 1), new Vector3(4, 1, 1));
        Gizmos.DrawLine(new Vector3(3, 1, 0), new Vector3(3, 1, 1));
        Gizmos.DrawLine(new Vector3(4, 1, 0), new Vector3(4, 1, 1));

        // Second Cube Line
        Gizmos.DrawLine(new Vector3(-4, 0, 0), new Vector3(-3, 0, 0)); ;//3==-4 , 4=-3
        Gizmos.DrawLine(new Vector3(-4, 0, 0), new Vector3(-4, 1, 0));
        Gizmos.DrawLine(new Vector3(-3, 0, 0), new Vector3(-3, 1, 0));
        Gizmos.DrawLine(new Vector3(-4, 1, 0), new Vector3(-3, 1, 0));
        Gizmos.DrawLine(new Vector3(-3, 0, 0), new Vector3(-3, 0, 1));
        Gizmos.DrawLine(new Vector3(-4, 0, 0), new Vector3(-4, 0, 1));
        Gizmos.DrawLine(new Vector3(-3, 0, 1), new Vector3(-3, 1, 1));
        Gizmos.DrawLine(new Vector3(-4, 0, 1), new Vector3(-4, 1, 1));
        Gizmos.DrawLine(new Vector3(-4, 0, 1), new Vector3(-3, 0, 1));
        Gizmos.DrawLine(new Vector3(-4, 1, 1), new Vector3(-3, 1, 1));
        Gizmos.DrawLine(new Vector3(-4, 1, 0), new Vector3(-4, 1, 1));
        Gizmos.DrawLine(new Vector3(-3, 1, 0), new Vector3(-3, 1, 1));


    }


}
