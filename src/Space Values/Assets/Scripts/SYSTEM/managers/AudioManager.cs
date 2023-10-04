using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class AudioManager : MonoBehaviour
{
    public AudioSource audioSourceBase;
    public AudioSource audioSourceChorus;
    public List<AudioClip> bases;
    public List<AudioClip> chorus;


    public sbyte testX;
    public sbyte testY;
    public sbyte testZ;
    // Start is called before the first frame update
    void Start()
    {
        audioSourceBase.clip = bases[0];
        audioSourceChorus.clip = chorus[0];
        audioSourceBase.Play();
        audioSourceChorus.Play();


    }

    // Update is called once per frame
    void Update()
    {
        SetEquationParameters(testX, testY, testZ);
    }
    public void SetEquationParameters(sbyte x, sbyte y, sbyte z)
    {
        audioSourceChorus.pitch = 0.69f * x;
    }
}
