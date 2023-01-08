using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shelf : MonoBehaviour
{

    public string kind;
    public GameObject contents;
    public GameObject sort;
    public Material mouseOn;
    public Material transparent;
    public int idx;
    UIMart uimart;
    UIKart uikart;
    private bool isClicked = false;


    private void Start()
    {
        uimart = FindObjectOfType<UIMart>();
        uikart = FindObjectOfType<UIKart>();
    }

    private void Update()
    {
        if (!uimart.isShelfClicked)
        {
            isClicked = false;
            gameObject.GetComponent<MeshRenderer>().material = transparent;
        }
    }
    public void OnMouseUpAsButton()
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
