using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    public string ItemName { get; protected set;}
    public int Price { get; protected set; }
    public string ImageName { get; protected set; }

    public Item(string name, int price)
    {
        ItemName = name;
        Price = price;
    }
}
