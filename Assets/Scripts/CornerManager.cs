using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

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

    public DepthOfField dof;

    public PostProcessVolume ppv;


    private void Awake()
    {
        uimart = FindObjectOfType<UIMart>();
        ppv = FindObjectOfType<PostProcessVolume>();
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
        ppv.profile.TryGetSettings(out dof);
        dof.aperture.value = 32f;
        for (int i = 0; i < pointobjects.Length; i++)
        {
            pointobjects[i].transform.localScale = new Vector3(0, 0, 0);
        }

        while (dof.aperture.value>=0)
        {
            dof.aperture.value -= 0.25f;
            yield return new WaitForSeconds(0.0005f);
        }

        if (uimart != null)
            uimart.txtCornerName.text = cornerNames[idx];
        RenderSettings.skybox = corners[idx];
        pointobjects[idx].transform.localScale = new Vector3(1f, 1f, 1f);
        depthofview = 130f;

        for (float i = 130; i>100f; i--)
        {  
            depthofview = i;
            Camera.main.fieldOfView = depthofview;
            yield return new WaitForSeconds(0.002f);
        }

        dof.aperture.value = 0f;

        while (dof.aperture.value <= 32)
        {
            dof.aperture.value += 0.25f;
            yield return new WaitForSeconds(0.0005f);
        }

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
