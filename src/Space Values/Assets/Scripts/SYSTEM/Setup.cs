using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Setup : MonoBehaviour
{
    //SetBuildInfo
    private GameInfo gameInfo;
    private TextMeshProUGUI build;
    //ResetMenu
    private GameObject menuDefault;
    private GameObject menuMain;
    private GameObject menuOptions;
    private List<GameObject> l_menu = new List<GameObject>();

    // Start is called before the first frame update
    private void Start()
    {
        SetBuildInfo();
        ResetMenu();
    }



    private void SetBuildInfo()
    {
        gameInfo = GameObject.FindAnyObjectByType<GameInfo>();
        build = GameObject.Find("Build Info").GetComponent<TextMeshProUGUI>();


        build.text = gameInfo.Name + " - build v" + gameInfo.Version + " - " + gameInfo.Company + " - " + gameInfo.Info;
    }
    private void ResetMenu()
    {
        l_menu.Add(GameObject.Find("-MENU DEFAULT-").gameObject);
        l_menu.Add(GameObject.Find("-MAIN MENU-").gameObject);
        l_menu.Add(GameObject.Find("-OPTIONS-").gameObject);


        foreach(GameObject go in l_menu)
        {
            go.SetActive(false);
        }
    }
}
