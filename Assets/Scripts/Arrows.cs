using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrows : MonoBehaviour
{

    public Material mouseOn;
    public Material mouseDown;
    public float nextPointEulerAngle;
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
        StartCoroutine(CornerManager.GetInstance().ChangeCornerr(idx));
        //CornerManager.GetInstance().ChangeCorner(idx);

    }
}
