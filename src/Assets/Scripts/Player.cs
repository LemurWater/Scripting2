using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{

    private List<Weapon> weapons;


    public Player()
    {
            health = 8;
            speed = 2.0f;
    }





    public void Update()
    {
        Movement();
        Shoot();
    }







    public override void Movement()
    {
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Vector3 newPos = transform.position;
            newPos.x = newPos.x - speed * Time.deltaTime;

            transform.position = newPos;
        }
        else if(Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            Vector3 newPos = transform.position;
            newPos.x = newPos.x + speed * Time.deltaTime;

            transform.position = newPos;
        }

        

    }
    private void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) || Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Shoot");
        }
    }


    public override void CheckCollision()
    {
        throw new System.NotImplementedException();
    }

    public override void Death()
    {
        throw new System.NotImplementedException();
    }

    public override void TakeDamage(byte amount)
    {
        throw new System.NotImplementedException();
    }










    private void PickWeapon(PickUp pickUp)
    {

    }
    private void SwapWeapon()
    {

    }
    private void ChangeWeapon(Weapon newWeapon)
    {
        foreach(Weapon w in weapons)
        {
            if(w != newWeapon)
            {
                weapons.Add(newWeapon);
            }
        }
    }
}
