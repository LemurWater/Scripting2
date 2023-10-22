using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFacade : MonoBehaviour
{
    [SerializeField] private float spawnFrequency;

    float spawnTimer = 0.0f;

    [SerializeField] private bool working;
    [SerializeField] EnemyPool pool;
    [SerializeField] EnemyFactory enemyFactory;





    //Level1
    [Space(10)]
    [Header("Level 1")]
    public byte enemiesKilled = 0;
    public byte enemiesKilledThreshold = 3;
    [Space(10)]
    [Header("BOSS")]
    [SerializeField] private float level1Planets = 3;
    [SerializeField] private Transform spawnPointA;
    [SerializeField] private bool bossSection = false;

    // Start is called before the first frame update
    void Start()
    {
        spawnTimer = spawnFrequency;
    }

    // Update is called once per frame
    void Update()
    {
        Level1();
    }

    void Level1()
    {
        if (working)
        {
            if (spawnTimer <= 0.0f && level1Planets > 0)
            {
                //InstantiateEnemy();
                spawnTimer = spawnFrequency;
                level1Planets--;

                Enemy enemy = pool.Retrieve();
                if(enemy == null)
                {
                    return;
                }
                enemy.Reset(true);
                enemy.gameObject.transform.position = spawnPointA.position;
            }
            else if (level1Planets <= 0 && bossSection == false)
            {
                BossSection();
            }
            else
            {
                spawnTimer -= Time.deltaTime;
            }
        }
    }
    void BossSection()
    {
        Enemy enemy = pool.RetrieveBoss(); 
        if (enemy == null)
        {
            return;
        }
        enemy.gameObject.transform.position = spawnPointA.position;
        bossSection = true;
    }
}
