using UnityEngine.Networking;

public class AndroidMyCallback : AndroidCallback
{
    private NetworkManager mNetworkManager;

    public AndroidMyCallback(NetworkManager networkManager)
    : base()
    {
        mNetworkManager = networkManager;
    }
    public override void onClientReady(string ipaddr)
    {
        mNetworkManager.networkAddress = ipaddr;
        mNetworkManager.StartClient();
    }
    public override void onServerReady(string ipaddr)
    {
        mNetworkManager.StartHost();
    }
}
