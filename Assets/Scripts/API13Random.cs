using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class API13Random : MonoBehaviour {

    public Transform cube;
	// Use this for initialization
	void Start () {
        //Random.InitState( (int)System.DateTime.Now.Ticks );

        
	}
	
	// Update is called once per frame
    void Update()
    {
        //print(Random.Range(4, 10));
        //print(Random.Range(4, 5f));
        if (Input.GetKeyDown(KeyCode.Space))
        {
            print(Random.Range(4, 100));
            print((int)System.DateTime.Now.Ticks);
        }
        //cube.position = Random.insideUnitCircle * 5;
        cube.position = Random.insideUnitSphere * 5;
	}
}
