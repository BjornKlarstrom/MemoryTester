using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using System.IO;

public class ImageLoader : MonoBehaviour
{
    [SerializeField] string customTextureFilename = "mySkybox.png";
    UnityWebRequest unityWebRequest;
    RawImage image;

    void Start()
    {
        image = gameObject.GetComponent<RawImage>();
    }

    static string GetFileLocation(string relativePath)
    {
        return Path.Combine(Application.streamingAssetsPath, relativePath);
    }
    public void ToggleImage()
    {
        if (image.texture != null)
            image.texture = null;
        else
        {
            Debug.Log(GetFileLocation(customTextureFilename));
            StartCoroutine(ChangeImageCo());   
        }
        Resources.UnloadUnusedAssets();
        GC.Collect();
    }
    IEnumerator ChangeImageCo()
    {
        using (unityWebRequest = UnityWebRequestTexture.GetTexture(GetFileLocation(customTextureFilename)))
        {
            yield return unityWebRequest.SendWebRequest();

            if (unityWebRequest.result == UnityWebRequest.Result.ConnectionError ||
                unityWebRequest.result == UnityWebRequest.Result.ProtocolError)
            {
                Debug.Log(unityWebRequest.error);
            }
            else
            {
                image.texture = DownloadHandlerTexture.GetContent(unityWebRequest);
            }
        }
    }
}