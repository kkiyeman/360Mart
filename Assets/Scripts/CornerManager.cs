using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CornerManager : MonoBehaviour
{
    #region SingletoneMake
    public static CornerManager instance = null;
    public static CornerManager GetInstance()
    {
        if (instance == null)
        {
            GameObject go = new GameObject("@CornerManager");
            instance = go.AddComponent<CornerManager>();
        }
        return instance;
    }
    #endregion
    UIMart uimart;
    private bool isChanging;
    private float depthofview;
    private void Awake()
    {
        uimart = FindObjectOfType<UIMart>();
    }
    [SerializeField] Material[] corners;
    public PointObject[] pointobjects;
    public string[] cornerNames = new string[]{ "�����ǰ1", "�����ǰ2", "����1", "����", "����2", "��ŷ�",
                             "������ǰ", "Ư������1", "���ڷ�1", "���ڷ�2", "�ҽ���", "����2",
                             "����1", "Ư������2", "����ǰ1", "����ǰ2", "����ǰ3", "����ǰ4"};
    public void InitCornerData()
    {
        for (int i = 0; i < cornerNames.Length; i++)
        {
            corners = Resources.LoadAll<Material>($"Materials/BackgroundMaterials");
        }
    }


    public void CreatePointObjects()
    {
        pointobjects = new PointObject[cornerNames.Length];
        for(int i = 0; i< cornerNames.Length; i++)
        {
            Object Pobject = Resources.Load($"PointObjects/Objects{i+1}");
            GameObject pointObject = (GameObject)Instantiate(Pobject);
            PointObject PO = pointObject.GetComponent<PointObject>();
            pointobjects[i] = PO;
            pointobjects[i].gameObject.SetActive(false);
            pointobjects[i].transform.SetParent(Objectpool.GetInstance().transform);
        }

    }

    public IEnumerator ChangeCornerr(int idx)
    {
        depthofview = 100f;
        Camera.main.transform.rotation = Quaternion.Euler(0, 90f, 0);
        for(float i = 100; i>50f; i--)
        {
            depthofview = i;
            Camera.main.fieldOfView = depthofview;
            yield return new WaitForSeconds(0.005f);
        }
        yield return new WaitForSeconds(0.3f);

        Camera.main.fieldOfView = 100f;
        RenderSettings.skybox = corners[idx];
        Camera.main.transform.rotation = Quaternion.identity;
        if (uimart != null)
            uimart.txtCornerName.text = cornerNames[idx];

        for (int i = 0; i < pointobjects.Length; i++)
        {
            pointobjects[i].gameObject.SetActive(false);
        }
        pointobjects[idx].gameObject.SetActive(true);
    }
    public void ChangeCorner(int idx)
    { 
        RenderSettings.skybox = corners[idx];
        Camera.main.transform.rotation = Quaternion.identity;
        if (uimart != null)
         uimart.txtCornerName.text = cornerNames[idx];

        for (int i = 0; i < pointobjects.Length; i++)
        {
            pointobjects[i].gameObject.SetActive(false);
        }
        pointobjects[idx].gameObject.SetActive(true);
    }
}
