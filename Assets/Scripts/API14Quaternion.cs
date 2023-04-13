using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class API14Quaternion : MonoBehaviour {

    public Transform cube;

    public Transform player;
    public Transform enemy;
	// Use this for initialization
    void Start()
    {
        //cube.rotation = new Vector3(10, 0, 0);
        //cube.eulerAngles = new Vector3(10, 0, 0);
        //print(cube.eulerAngles);
        //print(cube.rotation);

        //cube.eulerAngles = new Vector3(45, 45, 45);
        //cube.rotation = Quaternion.Euler(new Vector3(45, 45, 45));
        //print(cube.rotation.eulerAngles);

        
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKey(KeyCode.Space)){
            Vector3 dir = enemy.position - player.position;
            dir.y = 0;
            Quaternion target= Quaternion.LookRotation(dir);
            player.rotation = Quaternion.Lerp(player.rotation, target, Time.deltaTime);
        }
	}
}
