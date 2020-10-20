using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // x and z axis movements, movement speed, action/ability for attack.
    // game over condition when health reaches 0.
    private Rigidbody playerRb;
    public float health = 100;
    private float zBoundPos = 15;
    private float xBoundPos = 15;
    private float speed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // set player movement
        playerMovement();

        // Set player movement boundaries
        playerBoundaries();

    }

    void playerMovement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        playerRb.AddForce(Vector3.forward * speed * verticalInput);
        playerRb.AddForce(Vector3.right * speed * horizontalInput);
    }

    void playerBoundaries()
    {
        if (transform.position.z < -zBoundPos)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zBoundPos);
        }

        if (transform.position.x < -xBoundPos)
        {
            transform.position = new Vector3(-xBoundPos, transform.position.y, transform.position.z);
        }

        if (transform.position.z > zBoundPos)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zBoundPos);
        }

        if (transform.position.x > xBoundPos)
        {
            transform.position = new Vector3(xBoundPos, transform.position.y, transform.position.z);
        }
    }
}
