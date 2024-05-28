using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : Player
{
    public override void movement()
    {
        float movementrigthleft = Input.GetAxis("Horizontal") * Speed;
        movementrigthleft *= Time.deltaTime;
        float movementupdown = Input.GetAxis("Vertical") * Speed;
        movementupdown *= Time.deltaTime;
        transform.Translate(movementupdown, movementrigthleft, 0);
    }
    void Start()
    {
        
    }

    
    void Update()
    {
        movement();
    }
}
