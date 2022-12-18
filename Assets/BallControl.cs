using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    public Rigidbody rb;
    public float movespeed = 10f;
    public Vector3 initialImpulse;

    // Start is called before the first frame update
    void Start()
    {
      rb.AddForce(initialImpulse, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
