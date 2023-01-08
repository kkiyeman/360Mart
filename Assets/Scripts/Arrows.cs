using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrows : MonoBehaviour
{

    public Material mouseOn;
    public Material mouseDown;
    public int idx;

    public void OnMouseEnter()
    {
        gameObject.GetComponent<MeshRenderer>().material = mouseOn;
    }
    public void OnMouseExit()
    {
        gameObject.GetComponent<MeshRenderer>().material = mouseDown;
    }
    public void OnMouseDown()
    {

        CornerManager.GetInstance().ChangeCorner(idx);

    }
}