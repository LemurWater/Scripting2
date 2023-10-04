using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    public float speed;


    public void Update()
    {
        Vector3 newPos = transform.position;
        newPos.y = newPos.y - (speed * Time.deltaTime);

        transform.position = newPos;// * Time.deltaTime
    }
}
