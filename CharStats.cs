using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Character", menuName = "Character Creation/player Units")]
public class CharStats : ScriptableObject
{
    public string charName;
    public int attack;
    public int defense;
    public int speed;
    public int maxHealth;
    public Material newColor;

    public void PrintMessage()
    {
        Debug.Log("The"  + charName + "character has been loaded.");
    }
    public void RandomizeStates()
    {
        attack = Random.Range(1, 25);
        defense = Random.Range(1, 25);
        speed = Random.Range(1, 25);
        maxHealth = Random.Range(1, 25);
    }
    
}
