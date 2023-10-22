using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GasGiant : Giant
{
    [SerializeField] GameObject gameOver;
    [SerializeField] GameObject winScreen;


    /*public static GasGiant Instance { get; private set; }


    private void Awake()
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


    private void OnTriggerEnter(Collider collider)
    {
        CheckTrigger(collider);
    }
    private protected override void CheckTrigger(Collider collider)
    {
        if (collider != null)
        {
            GameObject go = collider.gameObject;

            if (go.tag == "Matrioska Brain")
            {

                GameOver();

                return;
            }
            base.CheckTrigger(collider);
        }
    }
    public void GameOver()
    {
        Debug.Log("GAME OVER");
        gameOver.SetActive(true);
    }
    public void WinScreen()
    {
        Debug.Log("WIN SCREEN");
        winScreen.SetActive(true);
    }
    private protected override void Death()
    {
        WinScreen();
    }
}
