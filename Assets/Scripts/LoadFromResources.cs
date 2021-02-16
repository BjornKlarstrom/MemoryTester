using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using Random = UnityEngine.Random;

public class LoadFromResources : MonoBehaviour
{
    GameObject skyboxCameraPrefab;

    public void LoadResource()
    {
        if (skyboxCameraPrefab != null) return;
        skyboxCameraPrefab = Resources.Load<GameObject>("CameraSkyboxPrefab");
        InstantiateCameraSkybox(skyboxCameraPrefab);
    }
    void InstantiateCameraSkybox(GameObject skyboxCameraPrefab)
    {
        Instantiate(skyboxCameraPrefab);
    }

    public void DestroyNewSkybox()
    {
        if (skyboxCameraPrefab != null)
        {
            Destroy(skyboxCameraPrefab);
            Resources.UnloadUnusedAssets();
        }
    }
}
