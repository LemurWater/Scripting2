using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private byte damage;
    private Rigidbody rb;

    public byte Damage { get => damage; private set => damage = value; }

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
        Movement();
    }

    private void Movement()
    {
        /*transform.localPosition = new Vector3(transform.localPosition.x, 
            transform.localPosition.y , 
            transform.localPosition.z + (speed * Time.deltaTime));*/

        rb.velocity = transform.forward * speed; // * Time.deltaTime
    }
}
