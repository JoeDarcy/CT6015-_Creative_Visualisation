using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunPath : MonoBehaviour
{
    [SerializeField] private float moveSpeed;


    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
    }
}
