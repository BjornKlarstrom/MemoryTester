using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class LoadFromAddressable : MonoBehaviour
{
    public AssetReferenceT<Material> assetReference;

    public void UpdateSkyboxFromAddressable()  
    {
        Addressables.LoadAssetAsync<Material>(this.assetReference).Completed += SetSkybox;
    }

    static void SetSkybox(AsyncOperationHandle<Material> parameter)
    {
        RenderSettings.skybox = parameter.Result;
    }
}
