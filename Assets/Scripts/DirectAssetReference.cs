using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectAssetReference : MonoBehaviour
{
    public void GetAsset()
    {
        RenderSettings.skybox = Resources.Load<Material>("Skyboxes/skyboxAsset");
    }
}
