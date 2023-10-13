using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Item : ScriptableObject
{
    [SerializeField] private int id = 0;
    [SerializeField] private string itemName;
    [SerializeField] private Sprite itemIcon;
    [SerializeField] private int damage = 0;
}
