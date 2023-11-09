using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InventoryManager : MonoBehaviour
{
    [HideInInspector] public List<Item> inventory = new List<Item>();
    public GameObject inventoryItemPrefab;
    public Transform toolbarTransform;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RemoveItemFromKeyPress();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Weapon"))
        {
            // add item into inventory
            ItemPickup itemScript = other.gameObject.GetComponent<ItemPickup>();
            Item newItem = itemScript.GetItem();
            AddItem(newItem);
            Destroy(other.gameObject);
        }
    }

    private void AddItem(Item item)
    {
        inventory.Add(item);
        ListItems();
    }

    public void RemoveItem(Item item)
    {
        inventory.Remove(item);
        ListItems();
    }

    public void RemoveItem(int index)
    {
        inventory.RemoveAt(index);
        ListItems();
    }

    void RemoveItemFromKeyPress()
    {
        // check if one of the number keys were pressed
        for (int number = 1; number <= 9; number++)
        {
            if (Input.GetKeyDown(number.ToString()))
            {
                RemoveItem(number - 1);
                return;
            }
        }
    }

    private void ListItems()
    {
        // clear the inventory UI
        foreach (Transform item in toolbarTransform)
        {
            Destroy(item.gameObject);
        }

        // display all items in Inventory onto the UI
        foreach (Item item in inventory)
        {
            GameObject obj = Instantiate(inventoryItemPrefab, toolbarTransform);

            TextMeshProUGUI itemNameText = obj.GetComponentInChildren<TextMeshProUGUI>();
            itemNameText.text = item.itemName;

            Image itemIconImage = obj.GetComponent<Image>();
            itemIconImage.sprite = item.itemIcon;

        }
    }

}
