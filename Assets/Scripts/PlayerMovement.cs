using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update

    public int forwardForce = 2000;
    public int leftForce = 100;
    public int rightForce = 100;

    void Start()
    {

        // rb.useGravity = false;


    }

    // Update is called once per frame
    //use fixed usdate for physics 
    void FixedUpdate()
    {

        //add a forward force

        if (Input.GetKey("d"))
        {
            rb.AddForce(rightForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-leftForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        }

        if (rb.position.y <= -1f) {
            FindObjectOfType<GameManager>().EndGame();
        }


        // rb.AddForce(0, 200, 500 * Time.deltaTime);


    }
}
