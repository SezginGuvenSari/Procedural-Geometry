using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
public class SamuraiHead : MonoBehaviour
{
    Mesh mesh;
    public LineRenderer circleRend;
    private void Awake()
    {
        mesh = new Mesh();
        mesh.name = "Samurai Head";
        DrawCircle(100,1);
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

   

     public void DrawCircle(int steps,int radius)
    {
        circleRend.positionCount = steps;

        for (int currentStep = 0; currentStep < steps; currentStep++)
        {
            float circumferenceProgress = (float)currentStep /steps;
            float currentRadian = circumferenceProgress * 2 * Mathf.PI;

            float xScaled = Mathf.Cos(currentRadian);
            float yScaled = Mathf.Sin(currentRadian);
            float x = xScaled + radius;
            float y = yScaled + radius;

            Vector3 currentPosition = new Vector3(x, y, 0);

            circleRend.SetPosition(currentStep, currentPosition);

        }
    }
}
