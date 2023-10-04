using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

using UnityEngine.SceneManagement;

public enum ButtonType
{
    NewGame,
    Options,
    Exit,

    Return
}
public class ButtonMenu : MonoBehaviour
{
    public ButtonType type;

    public GameObject goMenu;
    public GameObject goOptions;


    public void Pressed()
    {
        switch(type)
        {
            case ButtonType.NewGame:
                SceneManager.LoadScene("Test", LoadSceneMode.Additive);
                break;

            case ButtonType.Options:
                goOptions.SetActive(true);
                goMenu.SetActive(false);
                break;

            case ButtonType.Exit:
                Application.Quit();
                break;


            case ButtonType.Return:
                goOptions.SetActive(false);
                goMenu.SetActive(true);
                break;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
