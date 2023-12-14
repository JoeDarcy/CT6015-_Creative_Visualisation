using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSpeedController : MonoBehaviour
{
    [Range(0.0f,50.0f)]
    [SerializeField] private float gameSpeed;
    [SerializeField] private float lerpSpeed;

    private float lerpTime;
    private bool startLerp;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            startLerp = true;
        }

        if (startLerp)
        {
            lerpTime += lerpSpeed * Time.deltaTime;
            Time.timeScale = Mathf.Lerp(Time.timeScale, gameSpeed, lerpTime);
        }
    }
}
