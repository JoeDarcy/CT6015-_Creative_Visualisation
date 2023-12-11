using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotation : MonoBehaviour
{
    [SerializeField] private float rotationSpeed;
    [SerializeField] private Vector3 axis;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(axis * rotationSpeed * Time.deltaTime);
    }
}
