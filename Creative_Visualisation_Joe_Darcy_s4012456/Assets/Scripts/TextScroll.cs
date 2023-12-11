using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextScroll : MonoBehaviour
{
    [SerializeField] private Vector3 endPosition;
    [SerializeField] private float scrollSpeed;

    private Vector3 startPosition;
    private float lerpPosition;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (lerpPosition < 1)
            lerpPosition += Time.deltaTime * scrollSpeed;

        transform.position = Vector3.Lerp(startPosition, endPosition, lerpPosition);
    }
}
