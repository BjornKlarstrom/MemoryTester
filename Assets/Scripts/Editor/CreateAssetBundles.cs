using UnityEditor;
using System.IO;

namespace Editor
{
    public static class CreateAssetBundles 
    {
        [MenuItem("Assets/Build AssetBundles")]
        static void BuildAllAssetBundles()
        {
            const string assetPath = "Assets/AssetBundles";
            if (!Directory.Exists(assetPath))
            {
                Directory.CreateDirectory(assetPath);
            }
            BuildPipeline.BuildAssetBundles(assetPath,
                BuildAssetBundleOptions.StrictMode,
                BuildTarget.StandaloneWindows);
        }
    }
}