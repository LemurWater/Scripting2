using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPool : MonoBehaviour
{

    [SerializeField] private int poolSize = 20;
    [SerializeField] private EnemyFactory enemyFactory;


    private List<Enemy> pool = new List<Enemy>();


    // Start is called before the first frame update
    void Start()
    {
        if(enemyFactory == null)
        {
            for(int i = 0; i < poolSize; i++)
            {
                CreateEnemyInstance();
            }
        }
    }

    private void CreateEnemyInstance()
    {
        Enemy enemyInstance = enemyFactory.CreateInstance();
        enemyInstance.pool = this;
        Recycle(enemyInstance);
    }
    public Enemy Retrieve()
    {
        Enemy e = null;

        if(pool.Count < 1) 
        {
            CreateEnemyInstance();
        }
        e = pool[0];
        pool.RemoveAt(0);
        e.Reset(true);

        return e;
    }
    public void Recycle(Enemy enemy)
    {
        enemy.Reset(false);
        pool.Add(enemy);
        enemy.transform.parent = transform;
        enemy.transform.position = transform.position;
        enemy.transform.rotation = transform.rotation;
        pool.Add(enemy);
    }
}