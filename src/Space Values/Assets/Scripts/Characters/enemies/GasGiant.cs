using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GasGiant : Giant
{
    [SerializeField] GameObject gameOver;
    private protected override void CheckCollision(Collision collision)
    {
        base.CheckCollision(collision);


        if (collision != null)
        {
            GameObject go = collision.gameObject;

            if (go.tag == "Matrioska Brain")
            {
                Debug.Log("GAME OVER");
                DestroyCelestialBody();
                gameOver.SetActive(true);

                return;
            }
        }
    }
}
