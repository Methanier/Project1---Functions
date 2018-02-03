using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoRoutinesExample : MonoBehaviour {

    private IEnumerator routineOne;
    private Coroutine routineTwo;

	// Use this for initialization
	void Start () {

        StartCoroutine(ExampleThree());

	}
	
	// Update is called once per frame
	void Update () {
		
        //Sets the routineOne variable to the Ienumerator ExampleOne then passes that to StartCoroutine
        if(Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("Start example one with function call");
            routineOne = ExampleOne();
            StartCoroutine(routineOne);
        }

        //Passes routineOne variable into StopCoroutine
        if(Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("Stop example one with function call");
            StopCoroutine(routineOne);

        }

        //Starts ExampleOne IEnumerator passing string value
        if(Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("Start example one with string call");
            StartCoroutine("ExampleOne");
        }

        //Stops ExampleOne IEnumerator passing string value
        if(Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("stop example one with string call");
            StopCoroutine("ExampleOne");
        }

        //Sets the varaible routineTwo to the Coroutine object retruned from StartCoroutine when passing in the function parameter
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Debug.Log("Start example two with function call");
            routineTwo = StartCoroutine(ExampleTwo());

        }

        //Passes the routineTwo variable into StopCorutine
        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            Debug.Log("Stop example two with function call");
            StopCoroutine(routineTwo);
        }

        //Starts ExampleTwo IEnumerator passing the string value
        if(Input.GetKeyDown(KeyCode.Alpha3))
        {
            Debug.Log("Start example two with string call");
            StartCoroutine("ExampleTwo");
        }

        //Stops ExampleTwo IEnumerator passing the string value
        if(Input.GetKeyDown(KeyCode.Alpha4))
        {
            Debug.Log("Stop example two with string call");
            StopCoroutine("ExampleTwo");
        }

        //Stops all running coroutines attached to this object
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Stop all coroutines");
            StopAllCoroutines();
        }

	}

    public IEnumerator ExampleOne()
    {
        Debug.Log("This is the first line of the coroutine");
        yield return null;

        Debug.Log("This is the second line of the coroutine");
        yield return new WaitForSeconds(2);

        Debug.Log("This is the last line of example one");
        yield return null;
    }

    public IEnumerator ExampleTwo()
    {
        while(true)
        {
            Debug.Log("This will keep happening");
            yield return null;
        }
    }

    public IEnumerator ExampleThree()
    {
        while(true)
        {
            Debug.Log("Example Three keeps happening");
            yield return new WaitForSeconds(2);
        }
    }
}
