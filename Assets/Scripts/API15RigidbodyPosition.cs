using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class API15RigidbodyPosition : MonoBehaviour {

    public Rigidbody playerRgd;
    public Transform enemy;
    public int force;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
    void Update()
    {
        //playerRgd.position = playerRgd.transform.position + Vector3.forward * Time.deltaTime*10;
        //playerRgd.MovePosition(playerRgd.transform.position + Vector3.forward * Time.deltaTime*10);\

        //if (Input.GetKey(KeyCode.Space))
        //{
        //    Vector3 dir = enemy.position - playerRgd.position;
        //    dir.y = 0;
        //    Quaternion target = Quaternion.LookRotation(dir);
        //    playerRgd.MoveRotation(Quaternion.Lerp(playerRgd.rotation, target, Time.deltaTime));
        //}
        playerRgd.AddForce(Vector3.forward * force);
	}
}
