using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<InventoryItem> items = new List<InventoryItem>();

    public void AddItem(InventoryItem newItem)
    {
        InventoryItem existing = items.Find(item => item.itemName == newItem.itemName);
        if (existing != null)
        {
            existing.quantity += newItem.quantity;
        }
        else
        {
            items.Add(newItem);
        }
    }

    public void RemoveItem(string itemName, int amount = 1)
    {
        InventoryItem item = items.Find(i => i.itemName == itemName);
        if (item != null)
        {
            item.quantity -= amount;
            if (item.quantity <= 0)
                items.Remove(item);
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
