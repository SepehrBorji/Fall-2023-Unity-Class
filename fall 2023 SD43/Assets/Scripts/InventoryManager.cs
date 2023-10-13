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
        if (other.CompareTag("Item"))
        {
            // add item into inventory
            ItemPickup itemScript = other.gameObject.GetComponent<ItemPickup>();
            Item newItem = itemScript.GetItem();
            inventory.Add(newItem);
            Destroy(other.gameObject);
        } // TO DO: MAKE ITEM TAG
    }

}
