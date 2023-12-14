using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunPath : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private bool startMoving;
    [SerializeField] private float lerpSpeed;
    [SerializeField] private Vector3 moveDirection;
    private float speed;
    private float lerpTime;
    


    // Update is called once per frame
    void Update()
    {
        if (startMoving)
        {
            lerpTime += lerpSpeed * Time.deltaTime;
            speed = Mathf.Lerp(speed, moveSpeed, lerpTime);
        }
        //Debug.Log(speed);
        transform.Translate(moveDirection * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            startMoving = true;

        }
    }
}
