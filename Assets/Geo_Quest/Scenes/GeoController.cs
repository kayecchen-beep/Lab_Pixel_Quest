using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeoController : MonoBehaviour
{
    int var = 3;
    string valueOne = "Hello";
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World");
        string valueOne = "World";
      
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {

            transform.position += new Vector3(0, 1, 0);
          
        }

        if (Input.GetKeyDown(KeyCode.D)) 
        { 
            transform.position += new Vector3(1, 0, 0); 
        }
            

    }
}
