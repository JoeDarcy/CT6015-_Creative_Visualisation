using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControllerAlt : MonoBehaviour
{
    [SerializeField] private int sceneToLoad;

    private SpriteRenderer spriteRenderer;
    private Color colour;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnMouseEnter()
    {
        colour = spriteRenderer.color;
        colour.a = 0.2f;
        spriteRenderer.color = colour;
    }

    private void OnMouseExit()
    {
        colour = spriteRenderer.color;
        colour.a = 0.05f;
        spriteRenderer.color = colour;
    }

    private void OnMouseDown()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
