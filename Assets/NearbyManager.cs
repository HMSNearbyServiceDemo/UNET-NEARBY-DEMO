using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NearbyManager
{
    AndroidCallback mAndroidCallback;
    public NearbyManager(AndroidCallback androidCallback)
    {
        mAndroidCallback = androidCallback;
    }

    public void startBroadcast()
    {
        AndroidJavaClass jc = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        AndroidJavaObject jo = jc.GetStatic<AndroidJavaObject>("currentActivity");
        jo.Call("startBroadcast", mAndroidCallback);
    }

    public void startDiscovery()
    {
        AndroidJavaClass jc = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        AndroidJavaObject jo = jc.GetStatic<AndroidJavaObject>("currentActivity");
        jo.Call("startDiscovery", mAndroidCallback);
    }
}

public class AndroidCallback : AndroidJavaProxy
{
    public AndroidCallback()
    : base("com.hms.nearbyjarforunity.IMyCallback")
    {
    }
    public virtual void onClientReady(string ipaddr)
    {
    }
    public virtual void onServerReady(string ipaddr)
    {
    }
}