using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarFactory : MonoBehaviour
{
    [SerializeField] private Star star;
    [Space(10)]
    [SerializeField] private float speed1 = 10.0f;
    [SerializeField] private float speed2 = 15.0f;
    [SerializeField] private float speed3 = 25.0f;

    //LEVEL 1
    private byte poolSizeStartLevel = 25;
    private byte poolSizeNormalLevel = 100;
    private byte poolSizeBoss = 10;



    public Star CreateInstance()
    {
        Star go = Instantiate(star);
        go.SetSpeed(speed1);

        return go;
    }
}
