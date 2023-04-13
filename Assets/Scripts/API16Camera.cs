using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class API16Camera : MonoBehaviour {

    private Camera mainCamera;
	// Use this for initialization
	void Start () {
        //mainCamera= GameObject.Find("MainCamera").GetComponent<Camera>();
        mainCamera = Camera.main;
	}
	
	// Update is called once per frame
	void Update () {
        //Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        //RaycastHit hit;
        //bool isCollider = Physics.Raycast(ray, out hit);
        //if (isCollider)
        //{
        //    Debug.Log(hit.collider);
        //}

        Ray ray = mainCamera.ScreenPointToRay(new Vector3(200, 200, 0));
        Debug.DrawRay(ray.origin, ray.direction * 10, Color.yellow);
	}
}
