using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Safezone : MonoBehaviour
{ 
    #region SingletoneMake
    public static Safezone instance = null;
    public static Safezone GetInstance()
    {
        if (instance == null)
        {
            GameObject go = new GameObject("@Safezone");
            instance = go.AddComponent<Safezone>();
            DontDestroyOnLoad(go);
        }
        return instance;
    }
    #endregion

    public void CallSafezone()
    {
        SafezoneOn();
        Invoke("SafezoneOff", 0.3f);
    }
    public void SafezoneOn()
    {
        gameObject.SetActive(true);
    }
    public void SafezoneOff()
    {
        gameObject.SetActive(false);
    }

}