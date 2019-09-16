using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spaaaaace : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInput();
    }

    private void ProcessInput()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            print("IMACOMPUTA");
        }
        else if (Input.GetKey(KeyCode.A))
        {
            print("IMALEFTCOMPUTA");
        }
        else if (Input.GetKey(KeyCode.D))
        {
            print("IMARIGHTCOMPUTA");
        }
    }
}
