using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class API01EventFunction : MonoBehaviour {

    void Awake()
    {
        Debug.Log("Awake");
    }
    void OnEnable()
    {
        Debug.Log("Enable");
    }

	// Use this for initialization
	void Start () {
        Debug.Log("Start");
	}

    void FixedUpdate()
    {
        Debug.Log("FixedUpdate");
    }

	// Update is called once per frame
    void Update()
    {
        Debug.Log("Update");
	}
    void LateUpdate()
    {
        Debug.Log("LateUpdate");
    }

    void OnApplicationPause()
    {
        Debug.Log("OnApplicationPause");
    }

    void OnDisable()
    {
        Debug.Log("Disable");
    }

    void OnApplicatoinQuit()
    {
        Debug.Log("OnApplicationQuit");
    }

    void Reset()
    {
        Debug.Log("Reset");
    }
    void OnDestroy()
    {
        Debug.Log("OnDestroy");
    }
}
