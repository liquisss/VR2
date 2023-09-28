using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example2 : Example1
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnMouseDown()
    {
        sphere.gameObject.GetComponent<Renderer>().material.color = Color.red;
    }

    private void OnMouseUp()
    {
        sphere.gameObject.GetComponent<Renderer>().material.color = Color.black;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
