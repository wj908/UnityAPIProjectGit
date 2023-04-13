using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class API10Mathf : MonoBehaviour {

    public Transform cube;
    public int a = 8;
    public int b = 20;
    public float t = 0;
    public float speed = 3;
	// Use this for initialization
    void Start()
    {
        //print(Mathf.Deg2Rad);
        //print(Mathf.Rad2Deg);
        //print(Mathf.Infinity);
        //print(Mathf.NegativeInfinity);
        //print(Mathf.PI);
        //print(Mathf.Epsilon);


        //Debug.Log(Mathf.Floor(10.0F));
        //Debug.Log(Mathf.Floor(10.2F));
        //Debug.Log(Mathf.Floor(10.7F));
        //Debug.Log(Mathf.Floor(-10.0F));
        //Debug.Log(Mathf.Floor(-10.2F));
        //Debug.Log(Mathf.Floor(-10.7F));
        // 2 4 8 16 32
        //print(Mathf.ClosestPowerOfTwo(2));//4
        //print(Mathf.ClosestPowerOfTwo(3));//8
        //print(Mathf.ClosestPowerOfTwo(4));//8
        //print(Mathf.ClosestPowerOfTwo(5));//8
        //print(Mathf.ClosestPowerOfTwo(6));//8
        //print(Mathf.ClosestPowerOfTwo(30));//8
        //print(Mathf.Max(1, 2));//2
        //print(Mathf.Max(1, 2, 5, 3, 10));//10
        //print(Mathf.Min(1, 2));//1
        //print(Mathf.Min(1, 2, 5, 3, 10));//1
        //print(Mathf.Pow(4, 3));//64 
        //print(Mathf.Sqrt(3));//1.6

        cube.position = new Vector3(0, 0, 0);
	}
    void Update()
    {
        //cube.position = new Vector3(Mathf.Clamp(Time.time, 1.0F, 3.0F), 0, 0);
        //Debug.Log(Mathf.Clamp(Time.time, 1.0F, 3.0F));
        //print(Mathf.Lerp(a, b, t));

        //float x = cube.position.x;
        ////float newX = Mathf.Lerp(x, 10, Time.deltaTime);
        //float newX = Mathf.MoveTowards(x, 10, Time.deltaTime*speed);
        //cube.position = new Vector3(newX, 0, 0);

        //print(Mathf.MoveTowards(a, b, t));

        //print(Mathf.PingPong(t, 20));
        cube.position = new Vector3(5+Mathf.PingPong(Time.time*speed, 5), 0, 0);
    }
    private int hp = 100;
    void TakeDamage()
    {
        hp -= 9;

        //if (hp < 0)
        //    hp = 0;
        hp = Mathf.Clamp(hp,0, 100);
    }
}
