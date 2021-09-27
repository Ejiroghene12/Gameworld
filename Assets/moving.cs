using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving : MonoBehaviour
{
    public Rigidbody2D rb;
    public float thrust;
    public float turnThrust;
    private float thrustInput;
    private float turnInput;

    // use this for initialization
    void start () { 
    
    }

    // update is called once per frame
    void Update ()
    {
        // check for input from the keyboard
        thrustInput = Input.GetAxis("Vertical");
        turnInput = Input.GetAxis("Horizontal");
        
        rb.AddRelativeForce(Vector2.up * thrustInput);
        rb.AddTorque(turnInput);
    }

    void FixedUpdate()
    {
        
    }
}
