using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectFactory : MonoBehaviour
{
    [SerializeField] private Star star;
    [SerializeField] private List<Material> starMaterials;
    private int seed = 42069;

    public CelestialBody CreateCelestialBody()
    {
        CelestialBody cb = Instantiate(star);
        cb.GetComponentInChildren<Renderer>().material = starMaterials[RandomColor()];

        return cb;
    }

    private int RandomColor()
    {
        return Random.Range(0, starMaterials.Count + 1);
    }
}