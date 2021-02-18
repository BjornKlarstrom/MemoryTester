using System;
using System.IO;
using UnityEngine;

public class AssetBundleLoader : MonoBehaviour
{
    AssetBundle assetBundle;
    Skybox currentSkybox;
    readonly string assetBundlePath = Application.streamingAssetsPath;

    void Start()
    {
        if (Camera.main is { }) this.currentSkybox = Camera.main.GetComponent<Skybox>();
    }
    public void ToggleBundleAsset()
    {
        if (currentSkybox.material == null)
        {
            this.assetBundle = AssetBundle.LoadFromFile(Path.Combine(assetBundlePath, "sky4bundle"));
            Debug.Log(this.assetBundle != null ? "Loading AssetBundle is a... SUCCESS" : "ERROR Loading...");
            var material = this.assetBundle.LoadAsset<Material>("skybox4");
            currentSkybox.material = material;   
        }
        else
        {
            currentSkybox.material = null;
            assetBundle.Unload(true);
        }
    }
}