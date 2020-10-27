using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class BtnDiscover : MonoBehaviour
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
        nearbyManager.startDiscovery();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
