using UnityEngine;

public abstract class Character : CelestialBody
{
    [SerializeField] private protected byte health;
    public static byte maxHealth;


    private protected CharacterController controller;



    public byte Health { get => health; private set => health = value; }
    //public float Speed { get => speed; private set => speed = value; }

    //internal abstract void CheckCollision();
    protected void Default()
    {
        controller = gameObject.GetComponent<CharacterController>();
    }
 
    public void MoveFoward()
    {
        controller.Move(transform.forward * speed * Time.deltaTime);
    }
    public void MoveBackwards()
    {
        controller.Move(-transform.forward * speed * Time.deltaTime);
    }   /*
    public void TurnLeft()
    {
        controller.Move(-transform.right * xSpeed * Time.deltaTime);
    }
    public void TurnRight()
    {
        controller.Move(transform.right * xSpeed * Time.deltaTime);
    }*/

    public virtual void TakeDamage(byte amount)
    {
        health -= amount;
        CheckDeath();
    }
    private protected void CheckDeath()
    {
        Debug.Log("CheckDeath");
        if(health <= 0)
        {
            Death();
        }
    }
    private protected virtual void Death()
    {
        //Destroy(gameObject);
    }
}
