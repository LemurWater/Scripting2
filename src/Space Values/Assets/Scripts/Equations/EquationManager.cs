using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EquationManager : MonoBehaviour
{
    public Equation equation = new(1, 1, 1);
    public TextMeshProUGUI text;

    public sbyte x;
    public sbyte y;
    public sbyte z;


    // Start is called before the first frame update
    void Start()
    {
        SetEquation(DefaultEquation());

        UpdateEquationText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    Equation DefaultEquation()
    {
        return new Equation(x, y, z);
    }
    public void SetEquation(Equation newEquation)
    {
        equation = newEquation;
    }
    void UpdateEquationText()
    {
        text.text = equation.GetEquation();
    }
}
