using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : CelestialBody
{
    public StarPool pool { get; set; }


    private void Update()
    {
        //TwoDMovement();
        //TreeDMovement();
        GravityField();
    }

    void OnTriggerEnter(Collider collider)
    {
        CheckTrigger(collider);
    }

    /*
    private void TwoDMovement()
    {
        Vector3 newPos = transform.position;
        newPos.y = newPos.y - (Speed * Time.deltaTime);

        transform.position = newPos;// * Time.deltaTime
    }
    private void TreeDMovement()
    {
        var step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, -transform.forward * 500.0f, step);
    }*/
}
