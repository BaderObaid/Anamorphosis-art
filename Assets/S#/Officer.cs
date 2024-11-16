using System.Collections;
using System.Collections.Generic;
using Assignment18;
using UnityEngine;
namespace Assignment18
{
    public class Officer : CharacterClass
   {
      public Officer(string name, int health, Position position) : base(name, health, position) { }
      public override void DisplayInfo()
        {
            Debug.Log("Officer");
            base.DisplayInfo();
        }

   }

}
