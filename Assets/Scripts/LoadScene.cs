using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public string sceneName; // The name of the scene to load e.g. "Session3_Coding"

    public void LoadTheScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
