using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class API19SceneManager : MonoBehaviour {

	// Use this for initialization
	void Start () {

        print(SceneManager.sceneCount);
        print(SceneManager.sceneCountInBuildSettings);

        print(SceneManager.GetActiveScene().name);
        print(SceneManager.GetSceneAt(0).name);

        SceneManager.activeSceneChanged += OnActiveSceneChanged;
        SceneManager.sceneLoaded += OnSceneLoaded;
	}

    void OnActiveSceneChanged(Scene a,Scene b)
    {
        print(a.name);
        print(b.name);
    }
    void OnSceneLoaded(Scene a, LoadSceneMode mode)
    {
        print(a.name + "" + mode);
    }
    

	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //SceneManager.LoadScene(1);
            //SceneManager.LoadScene("02 - MenuScene");
            print(SceneManager.GetSceneByName("02 - MenuScene").buildIndex );
            SceneManager.LoadScene(1);
        }

	}
}
