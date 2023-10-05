using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Setup : MonoBehaviour
{
    public GameInfo gameInfo;
    public TextMeshProUGUI build;

    // Start is called before the first frame update
    void Start()
    {
        SetBuildInfo();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SetBuildInfo()
    {
        build.text = gameInfo.gameName + " - build v" + gameInfo.version + " - " + gameInfo.info;
    }
}
