using System.Collections;
using System.Collections.Generic;
using UnityEngine;

internal abstract class Giant : Enemy
{
    internal float radius = 5.0f;


    private void Explode()
    {

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
