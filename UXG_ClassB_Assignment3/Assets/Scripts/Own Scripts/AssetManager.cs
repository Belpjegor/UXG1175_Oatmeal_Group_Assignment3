using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public static class AssetManager
{
    public static void LoadUIAsset(string aAsset, Vector3 pos, Transform parent, System.Action<GameObject> onloaded)
    {
        Addressables.InstantiateAsync(string.Format("Assets/Prefabs/UI/{0}.prefab", aAsset), pos, Quaternion.identity, parent).Completed += (loadObj) =>
        {
            onloaded?.Invoke(loadObj.Result);
        };
    }
}
