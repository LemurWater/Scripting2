using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFactory : MonoBehaviour
{
    [SerializeField] private Enemy meteor;
    [SerializeField] private Enemy moon;
    [SerializeField] private Enemy planet;
    [SerializeField] private Enemy iceGiant;
    [SerializeField] private Enemy gasGiant;
    [Space(10)]
    [SerializeField] private float startingSpeed = 10.0f;

    //LEVEL 1
    private byte amountMeteors = 10;
    private byte amountPlanets = 3;
    private byte amountIceGiant = 1;
    private byte amountGasGiant = 1;


    public Enemy CreateInstance(Enemy e)
    {
        return Instantiate(e);
    }
    public Enemy CreateMeteor()
    {
        return CreateInstance(meteor);
    }
    public Enemy CraeteMoon()
    {
       return CreateInstance(moon);
    }
    public Enemy CreatePlanet()
    {
        return CreateInstance(planet);
    }
    public Enemy CrateIceGiant()
    {
        return CreateInstance(iceGiant);
    }
    public Enemy CreateGasGiant()
    {
        return CreateInstance(gasGiant);
    }
}
