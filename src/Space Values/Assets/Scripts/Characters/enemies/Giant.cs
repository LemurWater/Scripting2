using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Giant : Enemy
{
    private void Explode()
    {

    }
    private protected override void CheckTrigger(Collider collider)
    {
        base.CheckTrigger(collider);
    }
}
