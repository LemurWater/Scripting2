using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public abstract class Enemy : Character
{
    [SerializeField] private byte damage;



    public byte Damage { get => damage; private set => damage = value; }


    public EnemyPool pool { get; set; }


    private void Update()
    {
        GravityField();
    }


    void OnCollisionEnter(Collision collision)
    {
        CheckCollision(collision);
    }
    private protected override void CheckCollision(Collision collision)
    {
        base.CheckCollision(collision);

        if (collision != null)
        {
            GameObject go = collision.gameObject;
            if (go.tag == "Bullet")
            {
                Debug.Log("Collision: Enemy - Bullet");
                TakeDamage(go.GetComponent<Bullet>().Damage);
                Destroy(go);
                return;
            }
            else if (go.tag == "Player")
            {
                Debug.Log("Collision: Enemy - Player");
                go.GetComponent<Player>().TakeDamage(Damage);
                Death();
                return;
            }
        }
    }
}