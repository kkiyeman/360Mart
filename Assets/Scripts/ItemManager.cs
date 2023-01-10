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
            new Item("ºñºñ°í ¹¬ÀºÁö(400g)", 5300),
            new Item("Á¾°¡Áý ±èÄ¡(500g)", 12000),
            new Item("Ç®¹«¿ø °í¼ÒÇÑ ººÀ½±èÄ¡(190g)", 3500),
            new Item("MORN ´º(»ç°¢)¿ù³²½Ó(300g)", 14300),
            new Item("CJ´Ù´ã ¸¶ÆÄµÎºÎ ¾ç³ä(150g)", 1680),
            new Item("CJ´Ù´ã ¸ÅÄÞµÎºÎÁ¶¸² ¾ç³ä(140g)", 1590),
            new Item("Ã»¿ì ¶±ººÀÌ¾ç³ä(500g)", 6300),
            new Item("»çÁ¶ ±ñ¸ÞÃß¸®¾Ë(270g)", 3510),
        });
        itemList.Add(new List<Item>
        {
            new Item("½ºÆÔ(300g)", 4500),
            new Item("½ºÆÔ(300g)", 4500),
            new Item("½ºÆÔ(300g)", 4500),
            new Item("½ºÆÔ(300g)", 4500),
            new Item("½ºÆÔ(300g)", 4500),
            new Item("½ºÆÔ(300g)", 4500),
            new Item("½ºÆÔ(300g)", 4500),
            new Item("½ºÆÔ(300g)", 4500),
            new Item("½ºÆÔ(300g)", 4500),
            new Item("½ºÆÔ(300g)", 4500),
            new Item("½ºÆÔ(300g)", 4500),
            new Item("½ºÆÔ(300g)", 4500),
            new Item("½ºÆÔ(300g)", 4500),
            new Item("½ºÆÔ(300g)", 4500),
            new Item("½ºÆÔ(300g)", 4500),
            new Item("½ºÆÔ(300g)", 4500)
        });
        itemList.Add(new List<Item>
        {
            new Item("½ºÆÔ(300g)", 4500),
            new Item("½ºÆÔ(300g)", 4500),
            new Item("½ºÆÔ(300g)", 4500),
            new Item("½ºÆÔ(300g)", 4500),
            new Item("½ºÆÔ(300g)", 4500),
            new Item("½ºÆÔ(300g)", 4500),
            new Item("½ºÆÔ(300g)", 4500),
            new Item("½ºÆÔ(300g)", 4500),
            new Item("½ºÆÔ(300g)", 4500),
            new Item("½ºÆÔ(300g)", 4500),
            new Item("½ºÆÔ(300g)", 4500),
            new Item("½ºÆÔ(300g)", 4500),
            new Item("½ºÆÔ(300g)", 4500),
            new Item("½ºÆÔ(300g)", 4500),
            new Item("½ºÆÔ(300g)", 4500),
            new Item("½ºÆÔ(300g)", 4500)
        });
        itemList.Add(new List<Item>
        {
            new Item("½ºÆÔ(300g)", 4500),
            new Item("½ºÆÔ(300g)", 4500),
            new Item("½ºÆÔ(300g)", 4500),
            new Item("½ºÆÔ(300g)", 4500),
            new Item("½ºÆÔ(300g)", 4500),
            new Item("½ºÆÔ(300g)", 4500),
            new Item("½ºÆÔ(300g)", 4500),
            new Item("½ºÆÔ(300g)", 4500),
            new Item("½ºÆÔ(300g)", 4500),
            new Item("½ºÆÔ(300g)", 4500),
            new Item("½ºÆÔ(300g)", 4500),
            new Item("½ºÆÔ(300g)", 4500),
            new Item("½ºÆÔ(300g)", 4500),
            new Item("½ºÆÔ(300g)", 4500),
            new Item("½ºÆÔ(300g)", 4500),
            new Item("½ºÆÔ(300g)", 4500)
        });
        itemList.Add(new List<Item>
        {
            new Item("½ºÆÔ(300g)", 4500),
            new Item("½ºÆÔ(300g)", 4500),
            new Item("½ºÆÔ(300g)", 4500),
            new Item("½ºÆÔ(300g)", 4500),
            new Item("½ºÆÔ(300g)", 4500),
            new Item("½ºÆÔ(300g)", 4500),
            new Item("½ºÆÔ(300g)", 4500),
            new Item("½ºÆÔ(300g)", 4500),
            new Item("½ºÆÔ(300g)", 4500),
            new Item("½ºÆÔ(300g)", 4500),
            new Item("½ºÆÔ(300g)", 4500),
            new Item("½ºÆÔ(300g)", 4500),
            new Item("½ºÆÔ(300g)", 4500),
            new Item("½ºÆÔ(300g)", 4500),
            new Item("½ºÆÔ(300g)", 4500),
            new Item("½ºÆÔ(300g)", 4500)
        });
        itemList.Add(new List<Item>
        {
            new Item("½ºÆÔ(300g)", 4500),
            new Item("½ºÆÔ(300g)", 4500),
            new Item("½ºÆÔ(300g)", 4500),
            new Item("½ºÆÔ(300g)", 4500),
            new Item("½ºÆÔ(300g)", 4500),
            new Item("½ºÆÔ(300g)", 4500),
            new Item("½ºÆÔ(300g)", 4500),
            new Item("½ºÆÔ(300g)", 4500),
            new Item("½ºÆÔ(300g)", 4500),
            new Item("½ºÆÔ(300g)", 4500),
            new Item("½ºÆÔ(300g)", 4500),
            new Item("½ºÆÔ(300g)", 4500),
            new Item("½ºÆÔ(300g)", 4500),
            new Item("½ºÆÔ(300g)", 4500),
            new Item("½ºÆÔ(300g)", 4500),
            new Item("½ºÆÔ(300g)", 4500)
        });
        itemList.Add(new List<Item>
        {
            new Item("½ºÆÔ(300g)", 4500),
            new Item("½ºÆÔ(300g)", 4500),
            new Item("½ºÆÔ(300g)", 4500),
            new Item("½ºÆÔ(300g)", 4500),
            new Item("½ºÆÔ(300g)", 4500),
            new Item("½ºÆÔ(300g)", 4500),
            new Item("½ºÆÔ(300g)", 4500),
            new Item("½ºÆÔ(300g)", 4500),
            new Item("½ºÆÔ(300g)", 4500),
            new Item("½ºÆÔ(300g)", 4500),
            new Item("½ºÆÔ(300g)", 4500),
            new Item("½ºÆÔ(300g)", 4500),
            new Item("½ºÆÔ(300g)", 4500),
            new Item("½ºÆÔ(300g)", 4500),
            new Item("½ºÆÔ(300g)", 4500),
            new Item("½ºÆÔ(300g)", 4500)
        });


    }
    
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
