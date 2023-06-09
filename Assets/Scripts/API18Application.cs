﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class API18Application : MonoBehaviour {

	// Use this for initialization
	void Start () {

        print(Application.identifier);
        print(Application.companyName);
        print(Application.productName);
        print(Application.installerName);
        print(Application.installMode);
        print(Application.isEditor);
        print(Application.isFocused);
        print(Application.isMobilePlatform);
        print(Application.isPlaying);
        //print(Application.isWebPlayer);
        print(Application.platform);
        print(Application.unityVersion);
        print(Application.version);
        print(Application.runInBackground);

        Application.Quit();
        Application.OpenURL("www.sikiedu.com");
        ScreenCapture.CaptureScreenshot("游戏截图");

	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //UnityEditor.EditorApplication.isPlaying = false;
            SceneManager.LoadScene(1);
        }	
	}
}
