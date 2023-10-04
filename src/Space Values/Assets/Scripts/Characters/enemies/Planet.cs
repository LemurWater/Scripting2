using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : Enemy
{
    public Planet()
    {
        health = 45;
        speed = 1.5f;
    }




    public override void Ability()
    {
        throw new System.NotImplementedException();
    }

    public override void CheckCollision()
    {
        throw new System.NotImplementedException();
    }

    public override void Death()
    {
        throw new System.NotImplementedException();
    }

    public override void Movement()
    {
        throw new System.NotImplementedException();
    }

    public override void TakeDamage(byte amount)
    {
        throw new System.NotImplementedException();
    }
}
