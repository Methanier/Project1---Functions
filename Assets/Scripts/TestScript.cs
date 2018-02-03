using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void DoSomething()
    {
        for(int i = 0; i < 100; i ++)
        {
            Debug.Log("Index: " + i.ToString());
            Debug.Log("Time: " + Time.time);
        }
    }

    public IEnumerator NewCoroutine()
    {
        for (int i = 0; i < 100; i++)
        {
            Debug.Log("Index: " + i.ToString());
            Debug.Log("Time: " + Time.time);
            yield return null;
        }
    }
}
