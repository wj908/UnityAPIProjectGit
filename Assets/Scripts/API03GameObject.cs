﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class API03GameObject : MonoBehaviour {

    public GameObject go;
	// Use this for initialization
	void Start () {
		//1,第一种创建方法 
        //GameObject go = new GameObject("Cube");
        //2,第二种
        //根据prefab 
        //根据另外一个游戏物体
        //GameObject.Instantiate(prefab);//可以根据prefab 或者 另外一个游戏物体克隆
        //3,第三种 创建原始的几何体
        //GameObject.CreatePrimitive(PrimitiveType.Plane);
        //GameObject go = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //go.AddComponent<Rigidbody>();
        //// go.AddComponent<API01EventFunction>();

        //Debug.Log(go.activeInHierarchy);
        //go.SetActive(false);
        //Debug.Log(go.activeInHierarchy);
        //Debug.Log(go.tag);
        //Debug.Log(go.name);
        //Debug.Log(go.GetComponent<Transform>().name);


        //Light light = FindObjectOfType<Light>();
        //light.enabled = false;
        //Transform[] ts= FindObjectsOfType<Transform>();//不查找 未激活的游戏物体
        //foreach (Transform t in ts)
        //{
        //    Debug.Log(t);
        //}

        //GameObject go = GameObject.Find("Main Camera");
        //GameObject[] gos= GameObject.FindGameObjectsWithTag("MainCamera");
        GameObject go= GameObject.FindGameObjectWithTag("Finish");

        go.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
