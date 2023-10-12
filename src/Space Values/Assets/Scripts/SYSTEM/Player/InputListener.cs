using System.Collections;
using System.Collections.Generic;
using UnityEngine;

internal class InputListener : MonoBehaviour
{
    Hotkeys hotkeys;
    MenuManager menuManager;
    //CameraController cameraScript;

    private bool groundedPlayer;

    public Character character;


    // Start is called before the first frame update
    void Start()
    {
        hotkeys = GameObject.FindObjectOfType<Hotkeys>();
        menuManager = GameObject.FindObjectOfType<MenuManager>();
        //cameraScript = GameObject.FindAnyObjectByType<CameraController>();
    }

    // Update is called once per frame
    void Update()
    {
        Menu();
        Movement();
    }

    void Menu()
    {
        if (Input.GetKeyDown(hotkeys.MenuOptions))
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
    void Movement()
    {
        MoveUp();
        MoveDown();
        MoveLeft();
        MoveRight();
    }
    void MoveUp()
    {
        foreach (KeyCode keyCode in hotkeys.MoveUp)
        {
            if (Input.GetKey(keyCode))
            {
                character.MoveUp();
                return;
            }
        }
    }
    void MoveDown()
    {
        foreach (KeyCode keyCode in hotkeys.MoveDown)
        {
            if (Input.GetKey(keyCode))
            {
                character.MoveDown();
                return;
            }
        }
    }
    void MoveLeft()
    {
        foreach(KeyCode keyCode in hotkeys.MoveLeft)
        {
            if (Input.GetKey(keyCode))
            {
                character.MoveLeft();
                return;
            }
        }
    }
    void MoveRight()
    {
        foreach (KeyCode keyCode in hotkeys.MoveRight)
        {
            if (Input.GetKey(keyCode))
            {
                character.MoveRight();
                return;
            }
        }
    }
}
