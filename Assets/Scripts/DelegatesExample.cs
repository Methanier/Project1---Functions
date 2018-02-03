using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegatesExample : MonoBehaviour {

    VoidDelegateNoParam exampleOne;
    IntDelegateOneParam exampleTwo;

    // Use this for initialization
    void Start()
    {
        StartCoroutine("DelegatesExampleOne");
        StartCoroutine("DelegatesExampleTwo");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public delegate void VoidDelegateNoParam();
    public delegate int IntDelegateOneParam(int x);

    void One()
    {
        Debug.Log("This is part One");
    }

    void Two()
    {
        Debug.Log("This is part Two");
    }

    void Three()
    {
        Debug.Log("This is part Three");
    }

    string StringOne()
    {
        return "This is part one";
    }

    string StringTwo()
    {
        return "This is part Two";
    }

    string StringThree()
    {
        return "This is part Three";
    }

    int ParamterExampleOne(int x)
    {
        return x;
    }

    int ParamterExampleTwo(int y)
    {
        return y;
    }

    int ParameterExampleThree(int x, int y)
    {
        if (x > y)
        {
            return x;
        }
        else
        {
            return y;
        }
    }

    IEnumerator DelegatesExampleOne()
    {
        Debug.Log("Store function 'One' in delegate example one");
        exampleOne = One;
        Debug.Log("Call functions stored in delegate");
        exampleOne();
        yield return null;

        Debug.Log("Add function 'Two' in the delegate exampleOne");
        exampleOne += Two;
        Debug.Log("Call functions stored in delegate");
        exampleOne();
        yield return null;

        Debug.Log("Sets exampleOne to function 'Three'");
        exampleOne = Three;
        Debug.Log("Call functions stored in delegate");
        exampleOne();
        yield return null;
    }

    IEnumerator DelegatesExampleTwo()
    {
        Debug.Log("Sets exampleTwo to ParametExampleOne");
        exampleTwo = ParamterExampleOne;
        Debug.Log("Calls exampleTwo delegate passing in an int value");
        Debug.Log(exampleTwo(2));
        yield return null;

        Debug.Log("Adds ParameterExampleTwo to delegate exampleTwo");
        exampleTwo += ParamterExampleTwo;
        Debug.Log("Calls exampleTwo delegate passing in an int value");
        Debug.Log(exampleTwo(3));
        yield return null;

        //exampleTwo = ParameterExampleThree; causes compile error as ParameterExampleThree takes two parameters, not one
    }
}
