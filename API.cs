using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Networking;
using System.Collections.Generic;
using System.IO;
using System;
public class API : MonoBehaviour
{
    const string BundleFolder = "http://www.ndgstudio.com.tr/berkcan/";
    public List<string> LoadingObjectValue = new List<string>();
    public AssetBundle bundle;
    string bundleURL;
    public UnityWebRequest www;
    public List<Hash128> listOfCachedVersions = new List<Hash128>();
    public void GetBundleObject(UnityAction<GameObject> callback, Transform bundleParent)
    {
        StartCoroutine(GetDisplayBundleRoutine(callback, bundleParent));
    }

    IEnumerator GetDisplayBundleRoutine(UnityAction<GameObject> callback, Transform bundleParent)
    {
        for (int i = 0; i < listOfCachedVersions.Count; i++)
        {
            bundleURL = BundleFolder + LoadingObjectValue[i];

#if UNITY_ANDROID
            bundleURL += "Android";
#else
        bundleURL += "IOS";
#endif
            
            www = UnityWebRequestAssetBundle.GetAssetBundle(bundleURL);
                yield return www.SendWebRequest();
                print(www.downloadProgress.ToString()+"DownloadProgress");
                bundle = DownloadHandlerAssetBundle.GetContent(www);
                Debug.Log("Requesting bundle at " + bundleURL);
            
            Debug.Log("BundleUrl : " + bundleURL);

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            {
                if (Caching.IsVersionCached(bundleURL, listOfCachedVersions[i]))
                {
                    string rootAssetPath = bundle.GetAllAssetNames()[0];
                    GameObject arObject = Instantiate(bundle.LoadAsset(rootAssetPath) as GameObject, bundleParent);
                    callback(arObject);
                    
                }
                else if (!Caching.IsVersionCached(bundleURL, listOfCachedVersions[i]))
                {
                    if (bundle != null)
                    {
                        bundle.Unload(false);
                    }
                    while (!Caching.ready)
                    yield return null;
                    using (var wwww = WWW.LoadFromCacheOrDownload(bundleURL, listOfCachedVersions[i]))
                    {
                        yield return wwww;
                        if (!string.IsNullOrEmpty(wwww.error))
                        {
                            Debug.Log(wwww.error);
                            yield return null;
                        }
                        bundle = wwww.assetBundle;
                        string asset = bundle.GetAllAssetNames()[0];
                        GameObject game = Instantiate(bundle.LoadAsset(asset) as GameObject, new Vector3(0, 0, 0), Quaternion.identity);
                        callback(game);
                    }
                }
            }

        }
    }
}
