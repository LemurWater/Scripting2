using System.Collections;
using System.Collections.Generic;
using UnityEngine;

internal class Meteor : Enemy
{
    public Meteor()
    {
        health = 10;
        speed = 2.0f;
    }




    public override void Ability()
    {
        throw new System.NotImplementedException();
    }

    internal override void CheckCollision()
    {
        throw new System.NotImplementedException();
    }

    internal override void Death()
    {
        throw new System.NotImplementedException();
    }

    internal override void Movement()
    {
        throw new System.NotImplementedException();
    }

    internal override void TakeDamage(byte amount)
    {
        throw new System.NotImplementedException();
    }
}
