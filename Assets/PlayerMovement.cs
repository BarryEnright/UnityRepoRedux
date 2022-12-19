using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("up"))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(-20, 0, 0);
        }
         if (Input.GetKey("w"))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(-20, 0, 0);
        }
        if (Input.GetKeyDown("down"))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(20, 0, 0);
        }
        if (Input.GetKeyDown("s"))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(20, 0, 0);
        }
    }
}
