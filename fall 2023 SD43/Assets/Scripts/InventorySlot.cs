using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    public Item currentItem;
    private Button itemBtn;

    private InventoryManager inventoryManagerScript;

    // Start is called before the first frame update
    void Awake()
    {
        inventoryManagerScript = FindObjectOfType<InventoryManager>();
        itemBtn = GetComponent<Button>();
        itemBtn.onClick.AddListener(RemoveBtnClicked);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void RemoveBtnClicked()
    {
        inventoryManagerScript.RemoveItem(currentItem);
    }
}
