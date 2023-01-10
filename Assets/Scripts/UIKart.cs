using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIKart : MonoBehaviour
{

    [SerializeField] Button btnKart;
    [SerializeField] Image kartLog;
    [SerializeField] Button btnCheckout;
    [SerializeField] Button btnKartclose;
    public bool isOpen = false;
    void Start()
    {
        btnKart.onClick.AddListener(OnclickOpenKart);
        btnCheckout.onClick.AddListener(OpenCheckOut);
        btnKartclose.onClick.AddListener(OnclickCloseKart);
    }

    
    void Update()
    {
        
    }

    private void OnclickOpenKart()
    {
        isOpen = true;
        kartLog.gameObject.SetActive(true);  
    }
    private void OnclickCloseKart()
    {
        kartLog.gameObject.SetActive(false);
        isOpen = false;
    }

    private void OpenCheckOut()
    {
        SceneManager.LoadScene("CheckOut");
    }

}
