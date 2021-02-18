using System;
using UnityEngine;

public class LoadFromResources : MonoBehaviour{
    const string loadPath = "skyboxVariant";
    Skybox currentSkybox;
    
    void Start()
    {
        if (Camera.main is { }) currentSkybox = Camera.main.GetComponent<Skybox>();
    }
    public void LoadSkyboxFromResources()
    {
        if (currentSkybox.material == null)
        {
            var material = Resources.Load<Material>(loadPath);
            currentSkybox.material = material;   
        }
        else
        {
            currentSkybox.material = null;
        }
        Resources.UnloadUnusedAssets();
        GC.Collect();
    }
}
