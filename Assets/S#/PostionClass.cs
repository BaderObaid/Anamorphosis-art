using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
namespace Assignment18
{
  public class PostionClass
 {
public struct Position
    {
      public float E, W, K;

      public Position(float e, float w, float k)
      {
        E = e; // Why when i put words instead of just 1 letter it shows me an error ? 
        W = w;
        K = k;
      
      }

      public void PrintPosition()
        {
            Debug.Log("Genral Postion:"  + E + "W" + W + "and" + "K" + K);
        }

    } 
  

 }

}
