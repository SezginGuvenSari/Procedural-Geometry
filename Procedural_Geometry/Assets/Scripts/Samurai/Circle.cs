using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
    public LineRenderer circleRend;
  

    void Start()
    {
        DrawCircle(100, 1);
    }

   

    public void DrawCircle(int steps, int radius)
    {
        circleRend.positionCount = steps;

        for (int currentStep = 0; currentStep < steps; currentStep++)
        {
            float circumferenceProgress = (float)currentStep / steps;
            float currentRadian = circumferenceProgress * 2 * Mathf.PI;

            float xScaled = Mathf.Cos(currentRadian);
            float yScaled = Mathf.Sin(currentRadian);
            float x = xScaled + radius;
            float y = yScaled + radius;

            Vector3 currentPosition = new Vector3(5, 14, 0);

            circleRend.SetPosition(currentStep, currentPosition);

        }


    }

  
}
