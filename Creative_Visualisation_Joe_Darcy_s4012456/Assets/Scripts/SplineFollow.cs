using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Splines;

public class SplineFollow : MonoBehaviour
{
    [SerializeField] private SplineContainer splineCurve;
    public float speed = 2.0f; // Speed of movement along the spline
    private float t = 0.0f; // Parameter t for interpolation


    private void Update()
    {
        // Update parameter t based on speed and time
        t += Time.deltaTime * speed;

        // Ensure t stays within a valid range (0 to 1)
        t = Mathf.Clamp01(t);

        // Calculate the position on the spline using Bezier interpolation
        Vector3 newPosition = Vector3.Lerp(splineCurve.EvaluatePosition(t), splineCurve.EvaluatePosition(t), t);

        // Update the game object's position
        transform.position = newPosition;

        // Update spell direction to follow the spline
        Vector3 direction = Vector3.Lerp(splineCurve.EvaluateTangent(t), splineCurve.EvaluateTangent(t), t);
        transform.rotation = Quaternion.LookRotation(direction);

        // Reset time to loop movement around the spline
        if (t == 1)
        {
            t = 0;
        }
    }
}
