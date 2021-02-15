using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SeparateScenes : MonoBehaviour
{
    public void LoadNextScene()
    {
        if (SceneManager.GetActiveScene().buildIndex == SceneManager.sceneCount - 1)
            SceneManager.LoadScene(0);
        else
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
