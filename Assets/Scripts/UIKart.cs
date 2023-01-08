using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIKart : MonoBehaviour
{

    [SerializeField] Button btnKart;
    [SerializeField] Image kartLog;
    public bool isOpen = false;
    void Start()
    {
        btnKart.onClick.AddListener(OnclickOpenKart);   
    }

    
    void Update()
    {
        
    }

    private void OnclickOpenKart()
    {
        isOpen = true;
        kartLog.gameObject.SetActive(true);
         
    }
}
