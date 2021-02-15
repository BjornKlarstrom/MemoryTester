using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class DirectReferenceToggle : MonoBehaviour
{
    public Material[] skyboxes;

    public void ToggleMaterial()
    {
        var index = Random.Range(0, skyboxes.Length);
        Debug.Log(index);
        
        RenderSettings.skybox = skyboxes[index];

    }
}
