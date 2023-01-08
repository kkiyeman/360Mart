using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MartScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        KartManager kartmanager = KartManager.GetInstance();

        

        Objectpool objectpool = Objectpool.GetInstance();

        CornerManager cornermanager = CornerManager.GetInstance();
        cornermanager.InitCornerData();
        cornermanager.CreatePointObjects();
        cornermanager.ChangeCorner(0);

        UIManager uimanager = UIManager.GetInstance();
        uimanager.SetEventSystem();
        uimanager.OpenUI("UIMart");
        uimanager.OpenUI("UIKart");
        uimanager.OpenStaticUI("UIMain");

        var uiMart = uimanager.GetUI("UIMart");
        var uiKart = uimanager.GetUI("UIKart");
        var uiMain = uimanager.GetUI("UIMain");

        Safezone safezone = Safezone.GetInstance();
        

       
       // objectpool.Initialize(cornermanager.cornerNames.Length);




    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
