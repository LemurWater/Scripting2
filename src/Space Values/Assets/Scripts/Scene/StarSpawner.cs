using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;

public class StarSpawner : MonoBehaviour
{
    [SerializeField] private ObjectFactory objFactory;
    //[SerializeField] private Star star;
    [SerializeField] private Transform starsGroup;
    [SerializeField] private byte starCount;
    [SerializeField] private Queue<Star> stars = new Queue<Star>();
    [Space(5)]
    [SerializeField] private List<Transform> spawnPoints;
    [Space(10)]
    [Header("STATS")]
    [SerializeField] private float spawnRate = 0.5f;
    [SerializeField] private float spawnTimer = 0.0f;
    [SerializeField] private byte spawnIndex = 0;
    [SerializeField] private float startingSpeed = 10.0f;



    public static StarSpawner Instance { get; private set; }


    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    private void Start()
    {
        spawnTimer = spawnRate;


        GeneratePool();
    }

    // Update is called once per frame
    private void Update()
    {
        SpawnStars();
    }
        
    private void GeneratePool()
    {
        if(objFactory != null)
        {
            for (int i = 0; i < starCount; i++)
            {
                CreateInstance();
                CalculateSpawnIndex();
            }
        }
    }
    private void CreateInstance()
    {
        CelestialBody cbInstance = objFactory.CreateCelestialBody();
        cbInstance.Spawner = this;
        Recycle(cbInstance);
    }
    public Star Retrieve()
    {
        Star s = null;

        if (stars.Count < 1)
        {
            CreateInstance();
        }
        s = stars.Dequeue().GetComponent<Star>();
        s.Reset(true);
        s.SetSpeed(startingSpeed);
        SetRandomPosition(s.transform);

        return s;
    }
    public void Recycle(CelestialBody s)
    {
        s.Reset(false);
        s.transform.parent = starsGroup;
        s.transform.position = spawnPoints[spawnIndex].position;
        s.transform.rotation = spawnPoints[spawnIndex].rotation;
        CalculateSpawnIndex();

        if (s is Star)
        {
            stars.Enqueue(s as Star);
        }
        else if(s is Enemy)
        {

        }
    }


    private void SpawnStars()
    {
        if(spawnTimer <= 0.0f)
        {
            Retrieve();

            spawnTimer = spawnRate;
            CalculateSpawnIndex();
        }
        else
        {
            spawnTimer -= Time.deltaTime;
        }
    }
    private void SetRandomPosition(Transform trans)
    {
        trans.position = spawnPoints[spawnIndex].position;
        CalculateSpawnIndex();
    }
    private void CalculateSpawnIndex()
    {
        spawnIndex++;
        if (spawnIndex >= spawnPoints.Count)
        {
            spawnIndex = 0;
        }
    }
}
