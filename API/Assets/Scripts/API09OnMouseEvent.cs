using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class API09OnMouseEvent : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnMouseDown()
    {
        print("Down");
    }

    private void OnMouseUp()
    {
        print("Up");
    }

    private void OnMouseDrag()
    {
        print("Drag");
    }

    private void OnMouseEnter()
    {
        print("Enter");
    }

    private void OnMouseExit()
    {
        print("Exit");
    }

    private void OnMouseOver()
    {
        print("Over");
    }
}
