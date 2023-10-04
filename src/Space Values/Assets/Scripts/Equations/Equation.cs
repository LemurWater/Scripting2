using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equation : MonoBehaviour
{
    private sbyte grade;
    private byte lenght;
    private string equation;

    private sbyte x;
    private sbyte y;
    private sbyte z;

    public Equation(string newEquation)
    {
        equation = newEquation;
    }
    public Equation(sbyte setX, sbyte setY, sbyte setZ)
    {
        SetEquation(setX, setY, setZ);
    }
    public string GetEquation()
    {
        return equation;
    }
    public void SetEquation(sbyte newX, sbyte newY, sbyte newZ)
    {
        x = newX;
        y = newY;
        z = newZ;

        CheckGrade();
        SetString();
    }
    void CheckGrade()
    {
        if (x > y) grade = x;
        else if (y > z) grade = y;
        else grade = z;
    }
    void SetString()
    {
        char sX = ' ';
        char sY = '+';
        char sZ = '+';
        if (x < 0) sX = '-';
        if (y < 0) sY = '-';
        if (z < 0) sZ = '-';

        equation = sX.ToString() + x.ToString() + "x " + 
            sY.ToString() + " " + y.ToString() + "y " +
            sZ.ToString() + " " + z.ToString() + "z ";
    }
}