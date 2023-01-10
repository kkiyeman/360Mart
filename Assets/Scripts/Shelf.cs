using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Shelf : MonoBehaviour
{

    public string shlefNameShowing;
    public Material mouseOn;
    public Material transparent;
    public int idx;
    UIMart uimart;
    UIKart uikart;
    private bool isClicked = false;
    public PointObject curPO;
    List<List<Item>> shelfData;
    List<Item> itemData;
    List<Image> imgItems;

    private void Start()
    {
        curPO = GetComponentInParent<PointObject>();
        uimart = FindObjectOfType<UIMart>();
        uikart = FindObjectOfType<UIKart>();
        InitItemDataForShelf();
    }

    private void InitItemDataForShelf()
    {
        var Itemmanager = ItemManager.GetInstance();
        shelfData = Itemmanager.shelfList[curPO.idx];
        itemData = shelfData[idx];  
    }

    private void SetItemImage()
    {
        for(int i = 0; i< itemData.Count; i++)
        {

        }
    }
    

    private void Update()
    {
        if (!uimart.isShelfClicked)
        {
            isClicked = false;
            gameObject.GetComponent<MeshRenderer>().material = transparent;
        }
    }
    public void OnMouseDown()
    {
        if (!EventSystem.current.IsPointerOverGameObject())
        {
            if (uikart.isOpen)
                return;
            else
            {
                if (!uimart.isShelfClicked)
                {
                    if (!isClicked)
                    {
                        gameObject.GetComponent<MeshRenderer>().material = mouseOn;
                        isClicked = true;
                        uimart.isShelfClicked = true;
                        uimart.bgShelf.gameObject.SetActive(true);
                        uimart.txtShelfName.text = shlefNameShowing;
                    }
                }
            }

        }
    }
    public void OnMouseExit()
    {
        if(!isClicked)
        gameObject.GetComponent<MeshRenderer>().material = transparent;
    }

}
