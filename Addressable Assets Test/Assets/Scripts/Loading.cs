using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.AddressableAssets;

public class Loading : MonoBehaviour
{

    private AsyncOperationHandle<SceneInstance> sceneOpHandele;

    public void LoadSceneAddressable(string sceneName)
    {
        sceneOpHandele = Addressables.LoadSceneAsync(sceneName, activateOnLoad : true);
    }
}
