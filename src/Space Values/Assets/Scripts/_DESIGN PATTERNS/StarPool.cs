using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarPool : MonoBehaviour
{
    [SerializeField] private int poolSize = 20;
    [SerializeField] private StarFactory starFactory;
    [SerializeField] private Transform starPool;

    private List<Star> pool = new List<Star>();




    void Start()
    {
        if (starFactory == null)
        {
            for (int i = 0; i < poolSize; i++)
            {
                CreateStarInstance();
            }
        }
    }

    private void CreateStarInstance()
    {
        Star starInstance = starFactory.CreateInstance();
        starInstance.pool = this;
        Recycle(starInstance);
    }
    public Star Retrieve()
    {
        Star s = null;

        if (pool.Count < 1)
        {
            CreateStarInstance();
        }
        s = pool[0];
        pool.RemoveAt(0);
        s.Reset(true);

        return s;
    }
    public void Recycle(Star star)
    {
        star.Reset(false);
        pool.Add(star);
        star.transform.parent = starPool;
        star.transform.position = transform.position;
        star.transform.rotation = transform.rotation;
        pool.Add(star);
    }
}
