using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    #region SingletoneMake
    public static ItemManager instance = null;
    public static ItemManager GetInstance()
    {
        if (instance == null)
        {
            GameObject go = new GameObject("@ItemManager");
            instance = go.AddComponent<ItemManager>();

            DontDestroyOnLoad(go);
        }
        return instance;
    }
    #endregion
    public List<List<List<Item>>> shelfList = new List<List<List<Item>>>();
    public List<List<Item>> itemList = new List<List<Item>>();
    // Start is called before the first frame update
    void Awake()
    {
        InitItemData();
        InitShelfData();
    }

    private void InitShelfData()
    {
        shelfList.Add(itemList);
    }

    private void InitItemData()
    {
        itemList.Add(new List<Item> 
        {  
            new Item("���� ������(400g)", 5300),
            new Item("������ ��ġ(500g)", 12000),
            new Item("Ǯ���� ����� ������ġ(190g)", 3500),
            new Item("MORN ��(�簢)������(300g)", 14300),
            new Item("CJ�ٴ� ���ĵκ� ���(150g)", 1680),
            new Item("CJ�ٴ� ���޵κ����� ���(140g)", 1590),
            new Item("û�� �����̾��(500g)", 6300),
            new Item("���� ����߸���(270g)", 3510),
        });
        itemList.Add(new List<Item>
        {
            new Item("����(300g)", 4500),
            new Item("����(300g)", 4500),
            new Item("����(300g)", 4500),
            new Item("����(300g)", 4500),
            new Item("����(300g)", 4500),
            new Item("����(300g)", 4500),
            new Item("����(300g)", 4500),
            new Item("����(300g)", 4500),
            new Item("����(300g)", 4500),
            new Item("����(300g)", 4500),
            new Item("����(300g)", 4500),
            new Item("����(300g)", 4500),
            new Item("����(300g)", 4500),
            new Item("����(300g)", 4500),
            new Item("����(300g)", 4500),
            new Item("����(300g)", 4500)
        });
        itemList.Add(new List<Item>
        {
            new Item("����(300g)", 4500),
            new Item("����(300g)", 4500),
            new Item("����(300g)", 4500),
            new Item("����(300g)", 4500),
            new Item("����(300g)", 4500),
            new Item("����(300g)", 4500),
            new Item("����(300g)", 4500),
            new Item("����(300g)", 4500),
            new Item("����(300g)", 4500),
            new Item("����(300g)", 4500),
            new Item("����(300g)", 4500),
            new Item("����(300g)", 4500),
            new Item("����(300g)", 4500),
            new Item("����(300g)", 4500),
            new Item("����(300g)", 4500),
            new Item("����(300g)", 4500)
        });
        itemList.Add(new List<Item>
        {
            new Item("����(300g)", 4500),
            new Item("����(300g)", 4500),
            new Item("����(300g)", 4500),
            new Item("����(300g)", 4500),
            new Item("����(300g)", 4500),
            new Item("����(300g)", 4500),
            new Item("����(300g)", 4500),
            new Item("����(300g)", 4500),
            new Item("����(300g)", 4500),
            new Item("����(300g)", 4500),
            new Item("����(300g)", 4500),
            new Item("����(300g)", 4500),
            new Item("����(300g)", 4500),
            new Item("����(300g)", 4500),
            new Item("����(300g)", 4500),
            new Item("����(300g)", 4500)
        });
        itemList.Add(new List<Item>
        {
            new Item("����(300g)", 4500),
            new Item("����(300g)", 4500),
            new Item("����(300g)", 4500),
            new Item("����(300g)", 4500),
            new Item("����(300g)", 4500),
            new Item("����(300g)", 4500),
            new Item("����(300g)", 4500),
            new Item("����(300g)", 4500),
            new Item("����(300g)", 4500),
            new Item("����(300g)", 4500),
            new Item("����(300g)", 4500),
            new Item("����(300g)", 4500),
            new Item("����(300g)", 4500),
            new Item("����(300g)", 4500),
            new Item("����(300g)", 4500),
            new Item("����(300g)", 4500)
        });
        itemList.Add(new List<Item>
        {
            new Item("����(300g)", 4500),
            new Item("����(300g)", 4500),
            new Item("����(300g)", 4500),
            new Item("����(300g)", 4500),
            new Item("����(300g)", 4500),
            new Item("����(300g)", 4500),
            new Item("����(300g)", 4500),
            new Item("����(300g)", 4500),
            new Item("����(300g)", 4500),
            new Item("����(300g)", 4500),
            new Item("����(300g)", 4500),
            new Item("����(300g)", 4500),
            new Item("����(300g)", 4500),
            new Item("����(300g)", 4500),
            new Item("����(300g)", 4500),
            new Item("����(300g)", 4500)
        });
        itemList.Add(new List<Item>
        {
            new Item("����(300g)", 4500),
            new Item("����(300g)", 4500),
            new Item("����(300g)", 4500),
            new Item("����(300g)", 4500),
            new Item("����(300g)", 4500),
            new Item("����(300g)", 4500),
            new Item("����(300g)", 4500),
            new Item("����(300g)", 4500),
            new Item("����(300g)", 4500),
            new Item("����(300g)", 4500),
            new Item("����(300g)", 4500),
            new Item("����(300g)", 4500),
            new Item("����(300g)", 4500),
            new Item("����(300g)", 4500),
            new Item("����(300g)", 4500),
            new Item("����(300g)", 4500)
        });


    }
    
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
