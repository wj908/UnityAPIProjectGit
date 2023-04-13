using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class API11Input : MonoBehaviour {

    public Transform cube;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown("left shift"))
        //{
        //    print("left shift");
        //}
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    print("KeyDOwn");
        //}
        //if (Input.GetKeyUp(KeyCode.Space))
        //{
        //    print("KeyUp");
        //}
        //if (Input.GetKey(KeyCode.Space))
        //{
        //    print("Key");
        //}

        //if (Input.GetMouseButton(0))
        //    Debug.Log("Pressed left click.");

        //if (Input.GetMouseButton(1))
        //    Debug.Log("Pressed right click.");

        //if (Input.GetMouseButton(2))
        //    Debug.Log("Pressed middle click.");

        //if (Input.GetMouseButtonDown(0))
        //    Debug.Log("Pressed left click.");

        //if (Input.GetMouseButtonDown(1))
        //    Debug.Log("Pressed right click.");

        //if (Input.GetMouseButtonDown(2))
        //    Debug.Log("Pressed middle click.");

        //if (Input.GetButtonDown("Fire1"))
        //{
        //    print("Fire1 Down");
        //}

        //if (Input.GetButtonDown("Horizontal"))
        //{
        //    print("Horizontal Down"); 
        //}
        //print( );

        //cube.Translate(Vector3.right * Time.deltaTime * Input.GetAxis("Horizontal")*10);
        //cube.Translate(Vector3.right * Time.deltaTime * Input.GetAxisRaw("Horizontal")*10);

        //if (Input.anyKeyDown)
        //{
        //    print("any key down");
        //}

        print(Input.mousePosition);

	}
}
