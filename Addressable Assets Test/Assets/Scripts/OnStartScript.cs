using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.AddressableAssets;

public class OnStartScript : MonoBehaviour
{
    [SerializeField] private AssetReferenceGameObject gameObjectRef;
    [SerializeField] private AssetReferenceGameObject gameObjectRef1;
    [SerializeField] private AssetReferenceGameObject gameObjectRef2;

    private void OnEnable()
    {
        instantiateAddressable(gameObjectRef);
        instantiateAddressable(gameObjectRef1);
        instantiateAddressable(gameObjectRef2);

    }

    private void instantiateAddressable(AssetReferenceGameObject refra)
    {
        Debug.Log(refra.ToString());
        AsyncOperationHandle<GameObject> objectLoadOpHandel = Addressables.LoadAssetAsync<GameObject>(refra);
        if (refra == null)
            return;
        else
        {
            objectLoadOpHandel.Completed += ObjectLoadOpHandel_Completed;
        }
    }

    private void ObjectLoadOpHandel_Completed(AsyncOperationHandle<GameObject> asyncOperationHandle)
    {
        Debug.Log($"{asyncOperationHandle.Result} is Completed");
        Instantiate(asyncOperationHandle.Result);
    }
}
