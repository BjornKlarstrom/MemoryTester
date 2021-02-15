using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using System.IO;

public class ImageLoader : MonoBehaviour
{
    public string customTextureFilename = "BoratTwo";
    UnityWebRequest unityWebRequest;

    public static string GetFileLocation(string relativePath)
    {
        return Path.Combine(Application.streamingAssetsPath, relativePath);
    }
    public void ChangeImage()
    {
        Debug.Log(GetFileLocation(customTextureFilename));
        StartCoroutine(ChangeImageCo());
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
                gameObject.GetComponent<RawImage>().texture = DownloadHandlerTexture.GetContent(unityWebRequest);
            }
        }
    }
}