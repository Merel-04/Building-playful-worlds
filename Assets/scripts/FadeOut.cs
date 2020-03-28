using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FadeOut : MonoBehaviour
{
    public void LoadCutscene()
    {
        SceneManager.LoadScene("Cutscene");
    }
    public void LoadLevel0()
    {
        SceneManager.LoadScene("Level_0");
    }
    public void LoadLevel1()
    {
        SceneManager.LoadScene("Level-1");
    }
    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
