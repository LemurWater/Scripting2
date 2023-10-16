using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    [SerializeField] private byte maxHealh;
    [Space(5)]
    private Weapon weapon;
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform GunSocketA;
    [SerializeField] private Transform GunSocketB;
    [SerializeField] private Transform GunSocketC;




    public static Player Instance {  get; private set; }




    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        Default();
    }
    private void Update()
    {
        
    }



    internal void Shoot()
    {
        if(bullet != null)
        {
            GameObject go = Instantiate(bullet, GunSocketA.transform.position, transform.rotation);

            go.transform.rotation = transform.parent.rotation;
        }
    }

    private protected override void Death()
    {
        base.Death();
    }

    public override void TakeDamage(byte amount)
    {
        base.TakeDamage(amount);
    }




    public void PickUp(PickUpType type, byte amount)
    {
        switch(type)
        {
            case PickUpType.Weapon: PickWeapon(amount); break;
            case PickUpType.Ammo: PickAmmo(amount); break;
            case PickUpType.Health: PickHealth(amount); break;
        }
    }
    private void PickWeapon(byte index)
    {

    }
    private void PickAmmo(byte amount)
    {
        weapon.AddAmmo(amount);
    }
    private void PickHealth(byte amount)
    {
        health += amount;
        CheckMaxHealth();
    }
    private void CheckMaxHealth()
    {
        if (health > maxHealh)
        {
            health = maxHealh;
        }
    }
}
