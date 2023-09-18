using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    internal byte health;
    [SerializeField]
    internal float speed;

    public byte Health { get => health; set => health = value; }
    public float Speed { get => speed; set => speed = value; }


    public abstract void Death();
    public abstract void Movement();
    public abstract void CheckCollision();
    public abstract void TakeDamage(byte amount);
    private void CheckDeath()
    {

    }
}
