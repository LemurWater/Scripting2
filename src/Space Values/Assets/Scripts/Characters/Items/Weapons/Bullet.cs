using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private byte damage;

    [SerializeField] private float speed;
    [SerializeField] private CharacterController controller;

    public byte Damage { get => damage; set => damage = value; }



    // Start is called before the first frame update
    private void Start()
    {
        
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

        controller.Move(transform.forward * speed * Time.deltaTime); // * Time.deltaTime
    }
}
