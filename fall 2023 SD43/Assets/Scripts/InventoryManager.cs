using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public List<Item> inventory = new List<Item>();
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

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
        // TO DO: SHOW INVENTORY CONTENTS EVERYTIME SOMETHING IS ADDED OR REMOVED
    }

    private void AddItem(Item item)
    {
        inventory.Add(item);
        Debug.Log("Items: ");
        foreach (Item currentItem in inventory)
        {
            Debug.Log("Item Name: " + currentItem.itemName);
        }
    }

}
