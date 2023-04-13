using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class API09OnMouseEventFunction : MonoBehaviour {


    void OnMouseDown()
    {
        print("Down"+gameObject);
    }
    void OnMouseUp()
    {
        print("up" + gameObject);
    }
    void OnMouseDrag()
    {
        print("Drag" + gameObject);
    }
    
    void OnMouseEnter()
    {
        print("Enter");
    }
    void OnMouseExit()
    {
        print("Exit");
    }
    void OnMouseOver()
    {
        print("Over");
    }

    void OnMouseUpAsButton()
    {
        print("Button" + gameObject);
    }
    

}
