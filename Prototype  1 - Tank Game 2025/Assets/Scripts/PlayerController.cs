using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float rotSpeed;
    public float hInput;
    public float vInput;
    public float jumpForce;
    
    public Rigidbody playerRB;

    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxis("Horizontal");
        vInput = Input.GetAxis("Vertical");

        transform.Rotate(Vector3.up, hInput * rotSpeed * Time.deltaTime); //Rotates the vehicle left and right (side-to-side)
        transform.Translate(Vector3.forward * vInput * speed *Time.deltaTime); // Moves the vehicle forward and backward        
    }

}