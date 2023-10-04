using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    private float speed;
    private byte damage;
    //animation
    private float radius = 1.0f;


    public float GetSpeed()
    {
        return speed;
    }
    public byte GetDamage()
    {
        return damage;
    }
}
