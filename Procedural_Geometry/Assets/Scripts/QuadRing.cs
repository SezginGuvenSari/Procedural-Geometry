using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
public class QuadRing : MonoBehaviour
{

    [Range(0.01f, 1)]
    [SerializeField] float radiusInner;

    [Range(0.01f, 2)]
    [SerializeField] float thickness;

    [Range(3, 32)]
    [SerializeField] int angularSegmentCount = 3;

    Mesh mesh;

    float RadiusOuter => radiusInner + thickness;
    int VertexCount => angularSegmentCount * 2;

    void OnDrawGizmosSelected()
    {
        GizmosMn.DrawWireCircle(transform.position, transform.rotation, radiusInner, angularSegmentCount);
        GizmosMn.DrawWireCircle(transform.position, transform.rotation, RadiusOuter, angularSegmentCount);

    }


    void Awake()
    {

        mesh = new Mesh();
        mesh.name = "QuadRing";

        GetComponent<MeshFilter>().sharedMesh = mesh;
    }


    void Update() => GenerateMesh();


    void GenerateMesh()
    {
        mesh.Clear();

        int vCount = VertexCount;

        List<Vector3> vertices = new List<Vector3>();
        List<Vector3> normals = new List<Vector3>();
    

        for (int i = 0; i < angularSegmentCount + 1; i++)
        {

            float t = i / (float)angularSegmentCount;
            float angRad = t * Mathfs.TAU;
            Vector2 dir = Mathfs.GetUnitVektorByAngle(angRad);

            Vector3 zoffset = Vector3.forward * Mathf.Cos(angRad * 4);
            vertices.Add((Vector3)dir * RadiusOuter + zoffset);
            vertices.Add((Vector3)dir * radiusInner + zoffset);
            normals.Add(Vector3.forward);
            normals.Add(Vector3.forward);


          
        }

        List<int> triangleIndices = new List<int>();


        for (int i = 0; i < angularSegmentCount; i++)
        {

            int rootIndex = i * 2;
            int InnnerRoot = rootIndex + 1;

            int indexOuterNext = rootIndex + 2;
            int indexInnerNext = rootIndex + 3;

            triangleIndices.Add(rootIndex);
            triangleIndices.Add(indexOuterNext);
            triangleIndices.Add(indexInnerNext);
            triangleIndices.Add(rootIndex);
            triangleIndices.Add(indexInnerNext);
            triangleIndices.Add(InnnerRoot);

        }

        mesh.SetVertices(vertices);
        mesh.SetTriangles(triangleIndices, 0);
        mesh.SetNormals(normals);
    



    }

}
