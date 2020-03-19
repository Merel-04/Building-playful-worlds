using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class UIManagerScript : MonoBehaviour
{
    public Color defaultColor;
    public Color mouseOverColor;

    public MeshRenderer renderer;

    public float sineFrequency = 1; // Hoe snel
    public float sineMagnitude = 1; // Hoe hoog

    public void StartGame()
    {
        SceneManager.LoadScene("Test_Scene");
    }

    private void Update()
    {
        float sinWave = Mathf.Sin(Time.time * sineFrequency) * sineMagnitude;

        Vector3 pos = transform.position;
        pos.y += sinWave;
        transform.position = pos;

        transform.rotation = Quaternion.Euler(new Vector3(0, sinWave * 1500, sinWave * 500));
    }

    private void OnMouseDown()
    {
        StartGame();
    }

    private void OnMouseOver()
    {
        renderer.material.color = mouseOverColor;
    }

    private void OnMouseExit()
    {
        renderer.material.color = defaultColor;
    }

}
