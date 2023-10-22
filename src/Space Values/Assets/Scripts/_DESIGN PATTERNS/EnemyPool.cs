using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPool : MonoBehaviour
{
    [SerializeField] private int poolSize = 20;
    [SerializeField] private EnemyFactory enemyFactory;
    [SerializeField] private Transform enemyPool;

    [SerializeField] private Transform spawnPoint;

    private List<Enemy> pool = new List<Enemy>();

    public List<Enemy> Pool { get => pool; private set => pool = value; }
    public Enemy boss;


    void Start()
    {
        if(enemyFactory != null)
        {
            CreateGasGiant();

            for (int i = 0; i < poolSize; i++)
            {
                CreatePlanet();
            }
        }
    }

    private void CreatePlanet()
    {
        Enemy enemyInstance = enemyFactory.CreatePlanet();
        CreateInstance(enemyInstance);
    }
    private void CreateGasGiant()
    {
        Enemy enemyInstance = enemyFactory.CreateGasGiant();
        Recycle(enemyInstance);
        boss = enemyInstance;

    }
    private void CreateInstance(Enemy enemyInstance)
    {
        enemyInstance.pool = this;
        Recycle(enemyInstance);
    }

    public Enemy Retrieve()
    {
        Enemy e = null;
        if(Pool.Count < 1)
        {
            return null;
            //CreateEnemyInstance();
        }
        e = Pool[0];
        Pool.RemoveAt(0);
        e.Reset(true);
        //e.gameObject.transform.position = transform.position;

        return e;
    }
    public Enemy RetrieveBoss()
    {
        boss.Reset(true);
        return boss;
    }

    public void Recycle(Enemy enemy)
    {
        enemy.Reset(false);
        Pool.Add(enemy);
        enemy.transform.parent = enemyPool;
        enemy.transform.position = transform.position; 
        enemy.transform.rotation = transform.rotation;
        Pool.Add(enemy);
    }
}