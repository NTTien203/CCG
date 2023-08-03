using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CardSO", menuName = "CCG/CardSO", order = 0)]
public class CardSO : ScriptableObject {
    public string CardName;
    public string description;
    public Sprite artwork;
    public int attack;
    public int health;
}

