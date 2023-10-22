using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public static EnemySpawner Instance { get; private set; }

    [SerializeField] private EnemyPool enemyPool;



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
    

    public void SpawnPlanet()
    {
        if(enemyPool != null)
        {
            //Instantiate(enemyPool, transform.position, transform.rotation);
            enemyPool.Retrieve();
        }
    }
    public void SpawnGasGiant()
    {
        if (enemyPool != null)
        {
            //Instantiate(enemyPool, transform.position, transform.rotation);
            enemyPool.Retrieve();
        }
    }
}
