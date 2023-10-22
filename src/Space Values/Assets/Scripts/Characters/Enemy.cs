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


    void OnTriggerEnter(Collider collider)
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
    private protected override void DestroyCelestialBody()
    {
        Death();
        //pool.Recycle(this);
        //Spawner?.Recycle(this);
    }
    private protected override void Death()
    {
        pool.Recycle(this);
        enemyFacade.enemiesKilled++;
        Debug.Log("EnemiesKilled++");
    }
}