using UnityEngine;

internal abstract class Character : MonoBehaviour
{
    [SerializeField] private protected byte health;
    [SerializeField] private protected float speed;

    private protected CharacterController controller;



    internal byte Health { get => health; private set => health = value; }
    internal float Speed { get => speed; private set => speed = value; }



    internal abstract void Death();
    internal abstract void Movement();
    internal abstract void CheckCollision();
    internal abstract void TakeDamage(byte amount);
    void CheckDeath()
    {

    }
    internal void MoveUp()
    {
        controller.Move(transform.up.normalized * speed * Time.deltaTime);
    }
    internal void MoveDown()
    {
        controller.Move(-transform.up.normalized * speed * Time.deltaTime);
    }
    internal void MoveLeft()
    {
        controller.Move(-transform.right.normalized * speed * Time.deltaTime);
    }
    internal void MoveRight()
    {
        controller.Move(transform.right.normalized * speed * Time.deltaTime);
    }
}
