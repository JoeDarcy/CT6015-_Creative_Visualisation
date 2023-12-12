using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    private Scene currentScene;

    private void Start()
    {
        currentScene = SceneManager.GetActiveScene();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow) && currentScene.buildIndex < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(currentScene.buildIndex + 1);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow) && currentScene.buildIndex > 0)
        {
            SceneManager.LoadScene(currentScene.buildIndex - 1);
        }
    }
}
