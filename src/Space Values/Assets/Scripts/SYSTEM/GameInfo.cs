using System.Collections;
using System.Collections.Generic;
using UnityEngine;

internal class GameInfo : MonoBehaviour
{
    [SerializeField] private string gameName = "Space Values";
    [SerializeField] private string version = "0.14 pre-beta";
    [SerializeField] private string company = "Infinity Ga∞es";
    [SerializeField] private List<string> developers;
    [SerializeField] private string info = "";


    internal string Name { get => gameName; private set => gameName = value; }
    internal string Version { get => version; private set => version = value; }
    internal string Company { get => company; private set => company = value; }
    internal List<string> Developers { get => developers; private set => developers = value; }
    internal string Info { get => info; private set => info = value; }



    // Start is called before the first frame update
    void Start()
    {
        Developers.Add("WaterLemur");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
