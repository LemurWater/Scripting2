using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using NUnit.Framework;
using UnityEngine.UIElements;
using UnityEngine.Assertions;

public class TestMethods : MonoBehaviour
{
    private string equationGood;
    private string equationBad;
    private List<Equation> testEquationElements;


    private string eq1 = "2x + 2";

    private Equation[] resultEquationElements =
    {
        new Equation("x"),
        new Equation("x + 1"),
        new Equation("2x"),
        new Equation("2x + 1"),
        new Equation("2x + 2"),
        new Equation("3x"),
        new Equation("3x + 1"),
        new Equation("3x + 2"),
        new Equation("3x + 3"),
        new Equation("4x"),
        new Equation("4x + 1"),
    };

    public void Populate()
    {
        TestUtils.Populate(ref equationGood, resultEquationElements);
        TestUtils.Populate(ref equationBad, resultEquationElements);
        TestUtils.Populate(ref equationGood, resultEquationElements);
    }

    public List<Equation> ClassifyEquations(List<Equation> sourceList)
    {
        List<Equation> result = null;

        return result;
    }

    [Test]
    public void TestEquation()
    {
        Populate();

        Equation[] equation =  resultEquationElements;

        List<Equation> testedEquations = ClassifyEquations(testEquationElements);
        Assert.IsNotEmpty(testedEquations);
        Assert.IsTrue(testedEquations.Count == 2);


        Assert.IsTrue(testedEquations[0].HasSameElementsAtIndeces(equationGood));
        Assert.IsTrue(testedEquations[1].HasSameElementsAtIndeces(equationBad));
    }
    public string GetEquation(Equation equation)
    {
        return equation.GetEquation();
    }

}
