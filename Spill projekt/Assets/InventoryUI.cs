using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InventoryUI : MonoBehaviour
{
    public Inventory inventory;
    public GameObject slotPrefab;
    public Transform slotContainer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpdateUI();
    }
    public void UpdateUI()
    {
        foreach (Transform child in slotContainer)
            Destroy(child.gameObject);

        foreach (InventoryItem item in inventory.items)
        {
            GameObject slot = Instantiate(slotPrefab, slotContainer);
            slot.transform.Find("Icon").GetComponent<Image>().sprite = item.icon;
            slot.transform.Find("Quantity").GetComponent<TMP_Text>().text = item.quantity.ToString();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
