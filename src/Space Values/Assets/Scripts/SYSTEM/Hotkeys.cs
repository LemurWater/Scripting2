using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hotkeys : MonoBehaviour
{
    [Space(15)]
    [Header("System - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - ")]
    [Space(5)]
    public KeyCode console = KeyCode.Tilde;
    public KeyCode[] exitProgram = {KeyCode.LeftAlt, KeyCode.F4};
    public KeyCode[] toggleHUD = {KeyCode.LeftAlt, KeyCode.Z};
    [Space(15)]
    [Header("Camera - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - ")]
    [Space(5)]
    public KeyCode camPanUp = KeyCode.UpArrow;
    public KeyCode camPanDown = KeyCode.DownArrow;
    public KeyCode camPanLeft = KeyCode.LeftArrow;
    public KeyCode camPanRight = KeyCode.RightArrow;

    public KeyCode focusCharacter = KeyCode.Space;
    [Header("Default - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - ")]
    [Space(5)]
    public KeyCode primaryClick = KeyCode.Mouse0;
    public KeyCode secondaryClick = KeyCode.Mouse1;
    [Header("Character - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - ")]
    [Space(5)]
    public KeyCode moveCharacter = KeyCode.Mouse0;

    public KeyCode selfUse = KeyCode.LeftControl;
    [Header("Spells - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - ")]
    [Space(5)]
    public KeyCode spellA = KeyCode.Q;
    public KeyCode spellB = KeyCode.W;
    public KeyCode spellC = KeyCode.E;

    public KeyCode ultimate = KeyCode.R;

    public KeyCode interact = KeyCode.F;
    public KeyCode interact2 = KeyCode.D;

    public KeyCode special1 = KeyCode.Alpha1;
    public KeyCode special2 = KeyCode.Alpha2;
    public KeyCode special3 = KeyCode.Alpha3;
    public KeyCode special4 = KeyCode.Alpha4;
    public KeyCode special5 = KeyCode.Alpha5;
    public KeyCode special6 = KeyCode.Alpha6;
    [Header("Menu/Options - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - ")]
    [Space(5)]
    public KeyCode menuOptions = KeyCode.Escape;

    public KeyCode menuCharacter = KeyCode.C;
    public KeyCode menuInventory = KeyCode.I;
    public KeyCode menuSpells = KeyCode.K;
    public KeyCode menuParty = KeyCode.O;
    public KeyCode menuAlliance = KeyCode.P;
    [Header("Combat - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - ")]
    [Space(5)]
    public KeyCode lockEnemy = KeyCode.Z;
    public KeyCode attack = KeyCode.Mouse0;
   


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
