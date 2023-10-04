using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInfo : MonoBehaviour
{
    public string gameName = "Space Values";
    public string version = "0.3 pre-alpha";
    public string company = "Infinity Games";
    public List<string> developers;
    // Start is called before the first frame update
    void Start()
    {
        developers.Add("WaterLemur");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
