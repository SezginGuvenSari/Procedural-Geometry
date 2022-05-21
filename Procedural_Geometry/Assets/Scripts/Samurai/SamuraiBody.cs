using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
public class SamuraiBody : MonoBehaviour
{
    Mesh mesh;
    private void Awake()
    {
        mesh = new Mesh();
        mesh.name = "Samurai Body";

        GetComponent<MeshFilter>().sharedMesh = mesh;
    }

    void Update() => GenerateSamuraiBody();

    #region Generate Body
    public void GenerateSamuraiBody()
    {
        mesh.Clear();
        List<Vector3> verticesBody = new List<Vector3>()
        {
            new Vector3(-2,0,1), //0
            new Vector3(-1,0,1),  //1
            new Vector3(-2,0,-1), //2
            new Vector3(-1,0,-1), //3
            new Vector3(-2,2,1), // 4
            new Vector3(-1,2,1), // 5
            new Vector3(-2,2,-1), // 6
            new Vector3(-1,2,-1),  // 7
            new Vector3(1,0,1), //8
            new Vector3(2,0,1), //9
            new Vector3(1,0,-1), //10
            new Vector3(2,0,-1), //11
            new Vector3(1,2,1), //12
            new Vector3(2,2,1), //13
            new Vector3(1,2,-1), //14
            new Vector3(2,2,-1), //15
            new Vector3(-2.5f,2,1.5f), //16
            new Vector3(-0.5f,2,1.5f), //17
            new Vector3(-2.5f,2,-1.5f), //18
            new Vector3(-0.5f,2,-1.5f), //19
            new Vector3(-2.5f,6,-1.5f), //20
            new Vector3(-2.5f,6,1.5f), //21
            new Vector3(-0.5f,4,-1.5f), //22
            new Vector3(-0.5f,4,1.5f), //23
            new Vector3(0.5f,4,1.5f), //24
            new Vector3(0.5f,4,-1.5f), //25 
            new Vector3(2.5f,6,1.5f), // 26
            new Vector3(2.5f,6,-1.5f), //27
            new Vector3(0.5f,2,1.5f), //28
            new Vector3(2.5f,2,1.5f), //29
            new Vector3(0.5f,2,-1.5f), //30
            new Vector3(2.5f,2,-1.5f),  // 31
            new Vector3(-0.5f,6,-1.5f), //32
            new Vector3(0.5f,6,-1.5f), // 33
            new Vector3(-0.5f,6,1.5f), //34
            new Vector3(0.5f,6,1.5f),  // 35
            new Vector3(3,4,0), //36
            new Vector3(-3,4,0), //37
            new Vector3(-2.5f,6,1.5f), //38
            new Vector3(2.5f,6,1.5f), //39
            new Vector3(-2.5f,6,-2f), //40
            new Vector3(2.5f,6,-2f), //41
            new Vector3(-1.25f,10,1.25f), //42 
            new Vector3(1.25f,10,1.25f), //43 
            new Vector3(-1.25f,10,-1.25f), //44
            new Vector3(1.25f,10,-1.25f) //45

        };

        List<int> trianglesBody = new List<int>()
        {

            2,0,1,
            2,1,3,
            2,6,7,
            2,7,3,
            6,4,5,
            6,5,7,
            3,7,5,
            3,5,1,
            0,4,6,
            0,6,2,
            1,5,4,
            1,4,0,  //First 
            10,14,15,
            10,15,11,
            14,12,13,
            14,13,15,
            10,8,9,
            10,9,11,
            11,15,13,
            11,13,9,
            8,12,14,
            8,14,10,
            9,13,12,
            9,12,8, // Second
            18,16,17,
            18,17,19,
            19,22,23,
            19,23,17,
            16,21,20,
            16,20,18,
            20,21,26,
            20,26,27,
            22,23,24,
            22,24,25,
            28,24,25,
            28,25,30,
            30,28,29,
            30,29,31,          
            31,27,26,
            31,26,29,                  
            18,20,32,
            18,32,19,
            22,23,32,
            22,32,25,
            30,32,27,
            30,27,31,
            17,34,21,
            17,21,16,
            24,35,34,
            24,34,23,
            29,26,35,
            29,35,28,
            29,26,36,
            29,36,31,
            26,27,36,
            27,31,36,
            16,21,37,
            21,20,37,
            16,37,18,
            20,18,37 , // Main Body
            40,44,45,
            40,45,41,
            41,45,43,
            41,43,39,
            40,38,39,
            40,39,41,
            38,42,44,
            38,44,40,
            39,43,42,
            39,42,38,
            44,42,43,
            44,43,45

        };

        mesh.SetVertices(verticesBody);
        mesh.SetTriangles(trianglesBody, 0);
    }
    #endregion


}
