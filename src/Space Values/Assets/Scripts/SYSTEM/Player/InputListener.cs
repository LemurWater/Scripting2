using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputListener : MonoBehaviour
{
    [SerializeField] private Hotkeys hotkeys;
    [SerializeField] private MenuManager menuManager;
    //CameraController cameraScript;

    [SerializeField] private PlanetShip planetShip;



    [SerializeField] private MatrioskaBrain characterRotator;


    // Start is called before the first frame update
    private void Start()
    {
        hotkeys = GameObject.FindObjectOfType<Hotkeys>();
        menuManager = GameObject.FindObjectOfType<MenuManager>();
        //cameraScript = GameObject.FindAnyObjectByType<CameraController>();
    }

    // Update is called once per frame
    private void Update()
    {
        Menu();
        Movement();
        Actions();
    }

    private void Menu()
    {
        if (Input.GetKeyDown(hotkeys.MenuMain))
        {
            if (menuManager.MainMenu())
            {
                //cameraScript.canRotate = false;
            }
            else
            {
                //cameraScript.canRotate = true;
            }
        }
    }
    private void Movement()
    {
        MoveFoward();
        MoveBackwads();
        TurnLeft();
        TurnRight();
    }
    private void Actions()
    {
        Shoot();
    }
    private void Shoot()
    {
        if (Input.GetKeyDown(hotkeys.Shoot[0]) || Input.GetKeyDown(hotkeys.Shoot[1]))
        {
            planetShip.Shoot();
        }
    }
    private void MoveFoward()
    {
        foreach (KeyCode keyCode in hotkeys.MoveFoward)
        {
            if (Input.GetKey(keyCode))
            {
                planetShip.MoveFoward();
                return;
            }
        }
    }
    private void MoveBackwads()
    {
        foreach (KeyCode keyCode in hotkeys.MoveBackwards)
        {
            if (Input.GetKey(keyCode))
            {
                planetShip.MoveBackwards();
                return;
            }
        }
    }
    private void TurnLeft()
    {
        foreach(KeyCode keyCode in hotkeys.MoveLeft)
        {
            if (Input.GetKey(keyCode))
            {
                characterRotator.TurnLeft();
                //character.TurnLeft();
                return;
            }
        }
    }
    private void TurnRight()
    {
        foreach (KeyCode keyCode in hotkeys.MoveRight)
        {
            if (Input.GetKey(keyCode))
            {
                characterRotator.TurnRight();
                //character.TurnRight();
                return;
            }
        }
    }
}
