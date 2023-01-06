using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LoadStats : MonoBehaviour
{
    public CharStats charstat;

    public Text nameText;
    public Text attackText;
    public Text defenseText;
    public Text speedText;
    public Text maxHealthText;
    public MeshRenderer currentColor;
    // Start is called before the first frame update
    void Start()
    {
        DisplayStats();
        charstat.PrintMessage();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            charstat.RandomizeStates();
            DisplayStats();

        }
        
    }
    void DisplayStats()
    {
        nameText.text = "Name:" + charstat.charName;
        attackText.text = "Attack:" + charstat.attack;
        defenseText.text = "Defense:" + charstat.defense;
        speedText.text = "Speed:" + charstat.speed;
        maxHealthText.text = "Max Health:" + charstat.maxHealth;
        currentColor.material = charstat.newColor;
    }
}
