using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatrioskaBrain : Character
{
    [SerializeField] private byte maxHealth;
    [SerializeField] private byte shield;
    [SerializeField] private byte maxShield;
    [SerializeField] private byte crew = 3;
    [Space(5)]
    [SerializeField] private List<Transform> rings;
    [SerializeField] private float speed1;
    [SerializeField] private float speed2;
    [SerializeField] private float speed3;

    [SerializeField] private float playerRotSpeed;



    public static MatrioskaBrain Instance {  get; private set; }


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
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        RingsRotation();
    }

    private void RingsRotation()
    {
        rings[0].transform.Rotate(0.0f, speed1, 0.0f, Space.World);
        rings[1].transform.Rotate(speed2, speed2, speed2, Space.World);
        rings[2].transform.Rotate(0.0f, 0.0f, speed3, Space.World);
    }
    public void TurnLeft()
    {
        Vector3 tmp = new Vector3(0.0f, -playerRotSpeed * Time.deltaTime, 0.0f);
        transform.Rotate(tmp);
    }
    public void TurnRight()
    {
        Vector3 tmp = new Vector3(0.0f, playerRotSpeed * Time.deltaTime, 0.0f);
        transform.Rotate(tmp);
    }


    public override void TakeDamage(byte amount)
    {
        byte overDamage = 0;
        if(shield > 0)
        {
            if(shield < amount)
            {
                overDamage = (byte)(amount - shield);
            }
            shield -= amount;
        }
        if(overDamage > 1)
        {
            health -= overDamage;
            CheckDeath();
        }
    }





    private protected override void Death()
    {
        throw new System.NotImplementedException();
        //GAME OVER
    }
}
