using TMPro;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private GameObject background;
    [SerializeField] private GameObject title;

    [SerializeField] private GameObject mainMenu;
    private GameObject optionsMenu;


    // Start is called before the first frame update
    private void Start()
    {
        //background = GameObject.Find("Menu Background");
        //title = GameObject.Find("Menu Title");

        //mainMenu = GameObject.Find("-MAIN MENU-");
        optionsMenu = GameObject.Find("-OPTIONS-");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool MainMenu()
    {
        if (mainMenu.activeInHierarchy == false)
        {
            mainMenu.SetActive(true);
            background.SetActive(true);
            title.SetActive(true);
            Cursor.lockState = CursorLockMode.Confined;
            return true;
        }
        else
        {
            mainMenu.SetActive(false);
            background.SetActive(false);
            title.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            return false;
        }
    }
    public void OptionsMenu()
    {
        if(optionsMenu.activeInHierarchy == false)
        {
            optionsMenu.SetActive(true);
        }
        else
        {
            optionsMenu.SetActive(false);
        }
    }
}
