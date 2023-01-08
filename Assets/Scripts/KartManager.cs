using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KartManager : MonoBehaviour
{
    #region SingletoneMake
    public static KartManager instance = null;
    public static KartManager GetInstance()
    {
        if (instance == null)
        {
            GameObject go = new GameObject("@KartManager");
            instance = go.AddComponent<KartManager>();

            DontDestroyOnLoad(go);
        }
        return instance;
    }
    #endregion


    
}
