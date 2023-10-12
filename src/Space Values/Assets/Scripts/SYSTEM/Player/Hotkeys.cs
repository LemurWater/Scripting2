using System.Collections;
using System.Collections.Generic;
using UnityEngine;

internal class Hotkeys : MonoBehaviour
{
    [Space(15)]
    [Header("System - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - ")]
    [Space(5)]
    [SerializeField] private KeyCode console = KeyCode.Tilde;
    [SerializeField] private KeyCode[] exitProgram = {KeyCode.LeftAlt, KeyCode.F4};
    [SerializeField] private KeyCode[] toggleHUD = {KeyCode.LeftAlt, KeyCode.Z};
    [Space(15)]
    [Header("Menu/Options - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - ")]
    [Space(5)]
    [SerializeField] private KeyCode menuOptions = KeyCode.Escape;
    [Header("Default - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - ")]
    [Space(5)]
    [SerializeField] private KeyCode primaryClick = KeyCode.Mouse0;
    [SerializeField] private KeyCode secondaryClick = KeyCode.Mouse1;
    [Header("Character - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - ")]
    [Space(5)]
    [Header("Movement - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - ")]
    [SerializeField] private KeyCode[] moveUp = { KeyCode.W, KeyCode.UpArrow };
    [SerializeField] private KeyCode[] moveDown = { KeyCode.S, KeyCode.DownArrow };
    [SerializeField] private KeyCode[] moveLeft = { KeyCode.A, KeyCode.LeftArrow };
    [SerializeField] private KeyCode[] moveRight = { KeyCode.D, KeyCode.RightArrow };
    [Header("Combat - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - ")]
    [SerializeField] private KeyCode[] shoot = { KeyCode.Space, KeyCode.Mouse0 };
    [SerializeField] private KeyCode[] swapWeapon = { KeyCode.LeftControl, KeyCode.Mouse1 };
    [Header("Abilities - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - ")]
    [Space(5)]
    [SerializeField] private KeyCode spellA = KeyCode.Q;
    [SerializeField] private KeyCode spellB = KeyCode.W;
    [SerializeField] private KeyCode spellC = KeyCode.E;

    [SerializeField] private KeyCode spellD = KeyCode.R;




    #region Accesors
    internal KeyCode Console { get => console; private set => console = value; }
    internal KeyCode[] ExitProgram { get => exitProgram; private set => exitProgram = value; }
    internal KeyCode[] ToggleHUD { get => toggleHUD; private set => toggleHUD = value; }
    internal KeyCode MenuOptions { get => menuOptions; private set => menuOptions = value; }
    internal KeyCode PrimaryClick { get => primaryClick; private set => primaryClick = value; }
    internal KeyCode SecondaryClick { get => secondaryClick; private set => secondaryClick = value; }
    internal KeyCode[] MoveUp { get => moveUp; private set => moveUp = value; }
    internal KeyCode[] MoveDown { get => moveDown; private set => moveDown = value; }
    internal KeyCode[] MoveLeft { get => moveLeft; private set => moveLeft = value; }
    internal KeyCode[] MoveRight { get => moveRight; private set => moveRight = value; }
    internal KeyCode[] Shoot { get => shoot; private set => shoot = value; }
    internal KeyCode[] SwapWeapon { get => swapWeapon; private set => swapWeapon = value; }
    internal KeyCode SpellA { get => spellA; private set => spellA = value; }
    internal KeyCode SpellB { get => spellB; private set => spellB = value; }
    internal KeyCode SpellC { get => spellC; private set => spellC = value; }
    internal KeyCode SpellD { get => spellD; private set => spellD = value; }
    #endregion Accesors


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
