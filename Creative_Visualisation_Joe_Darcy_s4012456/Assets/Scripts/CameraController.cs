using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private GameObject earthCamera;
    [SerializeField] private GameObject sunCamera;
    [SerializeField] private GameObject galaxyCamera;
    [SerializeField] private GameObject universeCamera;

    private int cameraSelector;


    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.RightArrow) && cameraSelector < 4)
        {
            cameraSelector++;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow) && cameraSelector > 0)
        {
            cameraSelector--;
        }

        switch (cameraSelector)
        {
            case 0:
                earthCamera.SetActive(true);
                sunCamera.SetActive(false);
                galaxyCamera.SetActive(false);
                universeCamera.SetActive(false);
                break;
            case 1:
                earthCamera.SetActive(false);
                sunCamera.SetActive(true);
                galaxyCamera.SetActive(false);
                universeCamera.SetActive(false);
                break;
            case 2:
                earthCamera.SetActive(false);
                sunCamera.SetActive(false);
                galaxyCamera.SetActive(true);
                universeCamera.SetActive(false);
                break;
            case 3:
                earthCamera.SetActive(false);
                sunCamera.SetActive(false);
                galaxyCamera.SetActive(false);
                universeCamera.SetActive(true);
                break;
            default:
                break;
        }
    }
}
