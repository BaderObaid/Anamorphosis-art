using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.Animations;
namespace Assignment18
{
  public class CharacterClass : PostionClass
  {
     public string Name;
     private int health;
     protected Position position;
     

     public int Health
        {
            get { return health; }
            set
            {
                if (value > 100) health = 100;
                else if (value < 0) health = 0;
                else health = value;
            }
        }

           public CharacterClass(string name, int health, Position position)
           {
            Name = name;
            Health = health;
            this.position = position;

           }
public CharacterClass() : this("No name", 100, new Position(0, 0, 0)) { }

public virtual void DisplayInfo()
        {
            Debug.Log($"Name: {Name}, Health: {Health}");
            position.PrintPosition();
        }

        public void Attack(int damage, CharacterClass target)
        {
            target.Health -= damage;
            Debug.Log("" + Name + "attacked" + target.Name +"for" + damage + "damage");
        }
public void Attack(int damage, CharacterClass target, string Firing)
        {
            Attack(damage, target); 
            {

            }
            Debug.Log($"Attack type: {Firing}");
  }
} 

}