using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 17;
    public float turnSpeed = 15;
    public float horizontalInput;
    public float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        //transform.Translate(0,0,1); test code piece
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput); //this piece of code moves vehicle forward
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime); //this piece of code rotates vehicle
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput); test code piece
    }
}
