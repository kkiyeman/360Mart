using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objectpool : MonoBehaviour
{
    public static Objectpool instance = null;

    public GameObject pointObject;

    public Queue<PointObject> objectpool = new Queue<PointObject>();
    public static Objectpool GetInstance()
    {
        if (instance == null)
        {
            GameObject go = new GameObject("@Objectpool");
            instance = go.AddComponent<Objectpool>();
        }
        return instance;
    }
    // Start is called before the first frame update
    void Awake()
    {

    }

    public void Initialize(int initCount)
    {
        for (int i = 1; i < initCount+1; i++)
        {
            objectpool.Enqueue(CreateNewObject(i));
        }
    }

    public PointObject CreateNewObject(int i)
    {

            Object Pobject = Resources.Load($"PointObjects/Objects{i}");
            GameObject pointObject = (GameObject)Instantiate(Pobject);
            var PO = pointObject.GetComponent<PointObject>();
            PO.gameObject.SetActive(false);
            PO.transform.SetParent(transform);
            return PO;

    }

    public static PointObject GetObject()
    {
        if (instance.objectpool.Count > 0)
        {
            var PO = instance.objectpool.Dequeue();
            PO.transform.SetParent(null);
            PO.gameObject.SetActive(true);
            return PO;
        }
        else
            return null;
    }

    public static void ReturnObject(PointObject pointobject)
    {
        pointobject.gameObject.SetActive(false);
        pointobject.transform.SetParent(instance.transform);
        instance.objectpool.Enqueue(pointobject);
    }



}
