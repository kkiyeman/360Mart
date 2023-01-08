using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMart : MonoBehaviour
{
    [SerializeField] Button[] btnCorners;
    private bool isOpen = false;
    [SerializeField] Image cornerMenu;
    public Image bgShelf;
    public Image bgItemList;
    public Text txtCornerName;
    public Text txtShelfName;
    public Button btnInside;
    public Button btnCancel;
    public Button btnCloseItemList;
    public bool isShelfClicked = false;
   
    
    // Start is called before the first frame update
    void Start()
    {
        ButtonSetting();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void ButtonSetting()
    {
        for(int i = 0;i<btnCorners.Length;i++)
        {
            int idx = i;
            btnCorners[idx].onClick.AddListener(()=> {CornerManager.GetInstance().ChangeCorner(idx);});
        }
        btnInside.onClick.AddListener(OnClickInside);
        btnCancel.onClick.AddListener(OnClickCancel);
        btnCloseItemList.onClick.AddListener(OnClickCloseItemList);
    }

    private void OnClickCancel()
    {
        bgShelf.gameObject.SetActive(false);
        isShelfClicked = false;
    }

    private void OnClickInside()
    {
        bgItemList.gameObject.SetActive(true);
    }

    private void OnClickCloseItemList()
    {
        bgItemList.gameObject.SetActive(false);    
    }

    public void CornerMenu()
    {
        if (isOpen == false)
        {
            cornerMenu.gameObject.SetActive(true);
            isOpen = true;
        }
        else
        {
            cornerMenu.gameObject.SetActive(false);
            isOpen = false;
        }
    }


}

