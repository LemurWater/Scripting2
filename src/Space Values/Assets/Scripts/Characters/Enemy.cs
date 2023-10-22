using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public abstract class Enemy : Character
{
    [SerializeField] private protected byte damage;
    [SerializeField] EnemyFacade enemyFacade;

    public EnemyPool pool { get; set; }
    public byte Damage { get => damage; set => damage = value; }

    private void Update()
    {
        GravityField();
    }


    private protected override void CheckTrigger(Collider collider)
    {
        base.CheckTrigger(collider);

        if (collider != null)
        {
            GameObject go = collider.gameObject;
            if (go.tag == "Bullet")
            {
                Debug.Log("Collision: Enemy - Bullet = " + gameObject.name);
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
    private protected override void DestroyCelestialBody()
    {
        base.DestroyCelestialBody();
        //pool.Recycle(this);
        //Spawner?.Recycle(this);
    }
    private protected override void Death()
    {
        DestroyCelestialBody();

        pool.Recycle(this);
        enemyFacade.enemiesKilled++;
        Debug.Log("FACADE  = nemiesKilled++");
    }
    public override void ResetState(bool state)
    {
        base.ResetState(state);

        if (state)
        {
            health = 3;
        }
    }
}