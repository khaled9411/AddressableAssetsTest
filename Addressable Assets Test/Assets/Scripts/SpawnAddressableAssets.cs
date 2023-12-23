using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.AddressableAssets;
using System;

//4
//Make your assets type
[Serializable]
public class AssetReferenceScriptToCreatAssetsRefeanseType : AssetReferenceT<ScriptToCreatAssetsRefeanseType>
{
    public AssetReferenceScriptToCreatAssetsRefeanseType(string guid) : base(guid) { }
}

public class SpawnAddressableAssets : MonoBehaviour
{
    [SerializeField] private string QCase1 = "No Thing";
    //2
    //take any type of assets
    [SerializeField] private AssetReference WAssetReference;

    //3
    //And it is possible to specify the type of assets
    [SerializeField] private AssetReferenceGameObject EAssetReferenceGameoblect1;

    //4
    //Making a variable of the assets you made
    [SerializeField] private AssetReferenceScriptToCreatAssetsRefeanseType RAssetReferenceScriptToCreatAssetsRefeanseType;

    //5
    //We select the label whose elements we want to call
    [SerializeField] private AssetLabelReference TLabelReference1;

    //6
    [SerializeField] private AssetLabelReference YLabelReference2;

    //7
    //And it is possible to specify the type of assets
    [SerializeField] private AssetReferenceGameObject UAssetReferenceGameoblect2;

    void Update()
    {
        //1
        /// <summary>
        /// In this case, you take specify the asset type and then give it the path to instantiate it
        /// </summary>
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Addressables.LoadAssetAsync<GameObject>("Assets/Prefabs1/CR-TAXI-1.prefab").Completed +=
            (asyncOperationHandle) =>
            {
                if (asyncOperationHandle.Status == AsyncOperationStatus.Succeeded)
                {
                    Instantiate(asyncOperationHandle.Result);
                }
                else
                {
                    Debug.Log("Faild load thes Object");
                }

            };

        }

        //2
        /// <summary>
        /// Here you have to specify the asset type before use, but you do not have to set the path
        /// </summary>
        if (Input.GetKeyDown(KeyCode.W))
        {
            WAssetReference.LoadAssetAsync<GameObject>().Completed +=
            (asyncOperationHandle) =>
            {
                if (asyncOperationHandle.Status == AsyncOperationStatus.Succeeded)
                {
                    Instantiate(asyncOperationHandle.Result);
                }
                else
                {
                    Debug.Log("Faild load thes Object");
                }

            };

        }

        //3
        /// <summary>
        /// Here you do not have to specify the asset type before use, nor do you have to specify the path
        /// </summary>
        if (Input.GetKeyDown(KeyCode.E))
        {
            EAssetReferenceGameoblect1.LoadAssetAsync().Completed +=
            (asyncOperationHandle) =>
            {
                if (asyncOperationHandle.Status == AsyncOperationStatus.Succeeded)
                {
                    Instantiate(asyncOperationHandle.Result);
                }
                else
                {
                    Debug.Log("Faild load thes Object");
                }

            };

        }

        //4
        /// <summary>
        /// Here you do not have to specify the asset type before use, nor do you have to specify the path
        /// </summary>
        if (Input.GetKeyDown(KeyCode.R))
        {
            RAssetReferenceScriptToCreatAssetsRefeanseType.LoadAssetAsync().Completed +=
            (asyncOperationHandle) =>
            {
                if (asyncOperationHandle.Status == AsyncOperationStatus.Succeeded)
                {
                    Instantiate(asyncOperationHandle.Result);
                }
                else
                {
                    Debug.Log("Faild load thes Object");
                }

            };

        }

        //5
        /// <summary>
        /// Here we call the one asset via the label, And you must specify the type of asset
        /// </summary>
        if (Input.GetKeyDown(KeyCode.T))
        {
            Addressables.LoadAssetAsync<GameObject>(TLabelReference1).Completed +=
            (asyncOperationHandle) =>
            {
                if (asyncOperationHandle.Status == AsyncOperationStatus.Succeeded)
                {
                    Instantiate(asyncOperationHandle.Result);
                }
                else
                {
                    Debug.Log("Faild load thes Object");
                }

            };

        }

        //6
        /// <summary>
        /// Here we call all assets via the label, And you must specify the type of asset
        /// </summary>
        if (Input.GetKeyDown(KeyCode.Y))
        {
            Addressables.LoadAssetsAsync<GameObject>(YLabelReference2, (gameObject) =>
            {
                Instantiate(gameObject);
            });

        }

        //7
        /// <summary>
        /// You can also instantiate it directly
        /// </summary>
        if (Input.GetKeyDown(KeyCode.U))
        {
            UAssetReferenceGameoblect2.InstantiateAsync();
        }


    }
}
