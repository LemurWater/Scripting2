using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    private float speed;
    private byte damage;
    //animation
    private float radius = 1.0f;

    [SerializeField] private byte ammo;
    [SerializeField] private byte maxAmmo;



    public byte Ammo { get => ammo; private set => ammo = value; }
    public byte MaxAmmo { get => maxAmmo; private set => maxAmmo = value; }




    public float GetSpeed()
    {
        return speed;
    }
    public byte GetDamage()
    {
        return damage;
    }


    public void AddAmmo(byte ammount)
    {
        ammo += ammount;
        CheckMaxAmmo();
    }
    private void CheckMaxAmmo()
    {
        if (ammo > maxAmmo)
        {
            ammo = maxAmmo;
        }
    }
}
