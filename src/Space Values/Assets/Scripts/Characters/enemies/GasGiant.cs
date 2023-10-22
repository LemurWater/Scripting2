using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GasGiant : Giant
{
    [SerializeField] GameObject gameOver;


    public static GasGiant Instance { get; private set; }


    /*private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }*/



    private protected override void CheckTrigger(Collider collider)
    {
        base.CheckTrigger(collider);


        if (collider != null)
        {
            GameObject go = collider.gameObject;

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
