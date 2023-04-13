using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class API07Invoke : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //Invoke("Attack",3);	
        InvokeRepeating("Attack", 4, 2);
        CancelInvoke("Attack");
	}

    void Update()
    {
        bool res = IsInvoking("Attack");
        print(res);
    }

    void Attack()
    {
        print("攻击目标");
    }
}
