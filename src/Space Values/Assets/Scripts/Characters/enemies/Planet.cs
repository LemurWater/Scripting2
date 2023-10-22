using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : Enemy
{
    private void OnTriggerEnter(Collider collider)
    {
        CheckTrigger(collider);
    }
    private protected override void CheckTrigger(Collider collider)
    {
        base.CheckTrigger(collider);

        if (collider != null)
        {
            GameObject go = collider.gameObject;
            if (go.tag == "Bullet")
            {
                Debug.Log("Collision: Enemy - Bullet");
                TakeDamage(go.GetComponent<Bullet>().Damage);
                Destroy(go);
                return;
            }
            else if (go.tag == "Planet Ship")
            {
                Debug.Log("Collision: Enemy - Player");
                go.GetComponent<PlanetShip>().TakeDamage(damage);
                Death();
                return;
            }
        }
    }
}