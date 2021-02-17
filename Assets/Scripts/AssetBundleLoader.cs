using System;
using System.IO;
using UnityEngine;

public class AssetBundleLoader : MonoBehaviour
{
    AssetBundle assetBundle;
    const string assetBundlePath = "Assets/StreamingAssets/StreamingAssets";
    void Start()
    {
        LoadAssetBundle(assetBundlePath);
    }
    void LoadAssetBundle(string path)
    {
        this.assetBundle = AssetBundle.LoadFromFile(path);
        Debug.Log(this.assetBundle != null ? "Loading AssetBundle is a... SUCCESS" : "ERROR Loading...");
    }
    public void InstantiateAsset()
    {
        if (Camera.main is { }) Camera.main.GetComponent<Skybox>().material = assetBundle.LoadAsset<Material>("sky0bundle");
    }
}
