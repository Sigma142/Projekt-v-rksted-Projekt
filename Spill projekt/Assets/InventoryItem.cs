using UnityEngine;

public class InventoryItem : MonoBehaviour
{
    public string itemName;
    public Sprite icon;
    public int quantity;
    public InventoryItem(string name, Sprite icon, int quantity = 1)
    {
        this.itemName = name;
        this.icon = icon;
        this.quantity = quantity;
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
