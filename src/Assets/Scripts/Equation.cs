using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equation : MonoBehaviour
{
    private byte grade;
    private byte lenght;
    private string equation;


    public Equation(string newEquation)
    {
        equation = newEquation;
    }
    public string GetEquation()
    {
        return equation;
    }
}
