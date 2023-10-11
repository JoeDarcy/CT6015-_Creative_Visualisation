using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    [SerializeField] private int sceneToLoad;


    private void OnMouseDown()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
