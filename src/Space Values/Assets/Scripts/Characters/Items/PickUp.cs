using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    [SerializeField] private PickUpType type;
    [SerializeField] private byte amount;
    [Space(5)]
    [SerializeField] private protected Transform matrioskaBrain;
    [SerializeField] private float speed;
    [SerializeField] private byte health;


    public PickUpType Type { get => type; private set => type = value; }
    public byte Amount { get => amount; private set => amount = value; }



    private void Update()
    {
        Movement();
    }



    private void Movement()
    {
        var step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, matrioskaBrain.position, step);
    }


    void OnCollisionEnter(Collision collision)
    {
        if(collision != null)
        {
            GameObject go = collision.gameObject;
            if(go.tag == "Player")
            {
                go.GetComponent<Player>().PickUp(type, amount);
                PickedUp();
                return;
            }
            else if(go.tag == "Enemy")
            {
                Damaged(go.GetComponent<Enemy>().Damage);
                return;
            }
            else if(go.tag == "Matrioska Brain")
            {
                Destroyed();
                return;
            }
        }
    }

    void PickedUp()
    {
        Debug.Log("Picked up: " + type.ToString());
        Destroy(gameObject);
    }
    void Damaged(byte amount)
    {
        Debug.Log("Pick up damaged");
        health -= amount;
        if(health < 0)
        {
            Destroyed();
        }
    }
    void Destroyed()
    {
        Debug.Log("Pick up DESTROYED");
        Destroy(gameObject);
    }
}