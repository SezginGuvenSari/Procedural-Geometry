using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Translate : MonoBehaviour
{
     public float speed;
   
 
    void Update()
    {
        gameObject.transform.Rotate(Vector3.up * speed*Time.deltaTime );
    }
}
