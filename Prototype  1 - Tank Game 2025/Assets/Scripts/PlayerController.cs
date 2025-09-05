using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float rotSpeed;
    public float hInput;
    public float vInput;
    public float jInput;
    public float jumpForce;
    
    public Rigidbody playerRB;

    // Update is called once per framee
    void Update()
    {
        hInput = Input.GetAxis("Horizontal");
        vInput = Input.GetAxis("Vertical");
        jInput = Input.GetAxis("Jump");

        transform.Rotate(Vector3.up, hInput * rotSpeed * Time.deltaTime); //Rotates the vehicle left and right (side-to-side)
        transform.Translate(Vector3.forward * vInput * speed *Time.deltaTime); // Moves the vehicle forward and backward  
        transform.Translate(Vector3.up * jInput * jumpForce * Time.deltaTime); // Lets vehicle jump up    
    }

}