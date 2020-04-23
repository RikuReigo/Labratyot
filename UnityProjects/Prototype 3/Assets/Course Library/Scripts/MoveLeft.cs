using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{

    private float speed = 30;
    private PlayerControls playerControlsScript;
    private float leftBound = -15;

    // Start is called before the first frame update
    void Start()
    {
        playerControlsScript = GameObject.Find("Player").GetComponent<PlayerControls>();
    }

    // Update is called once per frame
    void Update()
    {
        // move objects and background left
        if (playerControlsScript.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        // Destroy obstacles that are out of bounds
        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
