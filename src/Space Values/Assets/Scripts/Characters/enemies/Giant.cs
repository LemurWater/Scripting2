using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Giant : Enemy
{
    internal float radius = 5.0f;


    private void Explode()
    {

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