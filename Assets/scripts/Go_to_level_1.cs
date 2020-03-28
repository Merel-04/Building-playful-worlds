using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Go_to_level_1 : MonoBehaviour
{
    void LoadScene1()
    {
        SceneManager.LoadScene("Level-1");
    }
}
