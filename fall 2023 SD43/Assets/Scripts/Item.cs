using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Item")]
public class Item : ScriptableObject
{
    [SerializeField] private int id = 0;
    public string itemName;
    [SerializeField] private Sprite itemIcon;
    [SerializeField] private int damage = 0;
}
