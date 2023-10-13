using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    [SerializeField] private Item item;

    public Item GetItem()
    {
        return item;
    }
}
