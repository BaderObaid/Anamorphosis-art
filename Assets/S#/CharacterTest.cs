using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment18
{


public class CharacterTest : MonoBehaviour
{
    void Start()
    {
     Soldier soldier = new Soldier("HighRank Solider", 90, new (5, 10, 15));
     Officer officer = new Officer("MilitaryOfficer", 80, new (3, 6, 9));   
     CharacterClass [] characters = { soldier, officer };

        foreach (CharacterClass character in characters)
        {
            character.DisplayInfo();
        }

        Debug.Log("" + soldier.Name +  "Health before attack:" + soldier.Health);
        officer.Attack(20, soldier, "shooting");
        Debug.Log("" + soldier.Name +  "Health after the attack:" + soldier.Health);
    }
}

}
