using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class BtnBroadcast : MonoBehaviour
{
    NetworkManager mNetworkManager;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = this.GetComponent<Button>();
        btn.onClick.AddListener(OnClick);
        mNetworkManager = GameObject.Find("NetworkManager").GetComponent<NetworkManager>();
    }

    private void OnClick()
    {
        Button btn = this.GetComponent<Button>();
        btn.enabled = false;
        AndroidMyCallback androidMyCallback = new AndroidMyCallback(mNetworkManager);
        NearbyManager nearbyManager = new NearbyManager(androidMyCallback);
        nearbyManager.startBroadcast();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
