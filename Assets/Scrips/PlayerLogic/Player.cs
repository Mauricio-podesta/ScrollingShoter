using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Player : MonoBehaviour
{
     public static int life;
     public static float Speed = 5;

   public abstract void  movement();
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
