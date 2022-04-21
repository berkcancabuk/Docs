using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Networking;
using System;
public class ContentController : MonoBehaviour {

    public API api;
    public void LoadContent()
    {
        DestroyAllChildren();
        api.GetBundleObject(OnContentLoaded, transform);
    }

    void OnContentLoaded(GameObject content) {
        //do something cool here
        Debug.Log("Loaded: " + content.name);
    }

    void DestroyAllChildren() {
        foreach (Transform child in transform) {
            Destroy(child.gameObject);
        }
    }
}
