using TMPro;
using UnityEngine;

internal class Setup : MonoBehaviour
{
    public GameInfo gameInfo;
    public TextMeshProUGUI build;

    // Start is called before the first frame update
    void Start()
    {
        gameInfo = GameObject.FindAnyObjectByType<GameInfo>();
        build = GameObject.FindAnyObjectByType<TextMeshProUGUI>();

        SetBuildInfo();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SetBuildInfo()
    {
        build.text = gameInfo.Name + " - build v" + gameInfo.Version + " - " + gameInfo.Company + " - " + gameInfo.Info;
    }
}
