using System.Collections;
using System.Collections.Generic;
using UnityEngine;

internal class Player : Character
{

    private List<Weapon> weapons;

    /*
    public Player()
    {
            health = 8;
            speed = 2.0f;
    }*/




    void Start()
    {
        controller = gameObject.GetComponent<CharacterController>();
    }
    void Update()
    {
        Movement();
        Shoot();
    }







    internal override void Movement()
    {

    }
    private void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) || Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Shoot");
        }
    }


    internal override void CheckCollision()
    {
        throw new System.NotImplementedException();
    }

    internal override void Death()
    {
        throw new System.NotImplementedException();
    }

    internal override void TakeDamage(byte amount)
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
