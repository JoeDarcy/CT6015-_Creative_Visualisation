using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    [SerializeField] private GameObject explosionVFXPrefab;

    private SunPath sunPathScript;
    private bool explosionTriggered;
    private float maxScale = 2.5f;
    private Vector3 scaleTarget;
    private float lerpTime;
    private float lerpSpeed = 0.001f;
    private bool reverseScale;

    // Start is called before the first frame update
    void Start()
    {
        sunPathScript = GetComponent<SunPath>();

        scaleTarget = new Vector3(maxScale, maxScale, maxScale);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.CompareTag("Andromeda") && transform.position.y <= 0)
        {
            sunPathScript.enabled = false;

            if (!explosionTriggered)
            {
                Instantiate(explosionVFXPrefab, transform.position, Quaternion.identity);
                explosionTriggered = true;
            }

            if (!reverseScale)
            {
                lerpTime += lerpSpeed * Time.deltaTime;
                transform.localScale = Vector3.Lerp(transform.localScale, scaleTarget, lerpTime);
            }
            else
            {
                lerpTime = 0.0005f;
                lerpTime -= lerpSpeed * Time.deltaTime;
                transform.localScale = Vector3.Lerp(transform.localScale, Vector3.zero, lerpTime);
            }

            if (transform.localScale.x > 2.4)
                reverseScale = true;


        }
        else if (gameObject.CompareTag("Milky_Way") && transform.position.y >= 0)
        {
            sunPathScript.enabled = false;
        }

    }
}
