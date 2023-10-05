using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "You made a new file!", menuName = "CheeseScript")]
public class NewBehaviourScript : ScriptableObject
{
    [SerializeField]
    private int age;

    [SerializeField]
    [Range(0, 10)]
    private int numberOfToes;

    public float hp;
    public float netWorth;
    public bool hasCheeseInPocket;
}
