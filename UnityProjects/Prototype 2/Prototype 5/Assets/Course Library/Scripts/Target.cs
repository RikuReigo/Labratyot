using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private Rigidbody targetRB;
    public int pointValue;
    public ParticleSystem explosionParticle;

    private float minSpeed = 11;
    private float maxSpeed = 16;
    private float maxTorque = 10;
    private float yPos = 2;
    private float xRange = 4;

    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        targetRB = GetComponent<Rigidbody>();

        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();

        targetRB.AddForce(randomForce(), ForceMode.Impulse);
        targetRB.AddTorque(randomTorque(), randomTorque(), randomTorque(), ForceMode.Impulse);

        transform.position = randomSpawnPos();      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    Vector3 randomForce()
    {
        return Vector3.up * Random.Range(minSpeed, maxSpeed);
    }

    float randomTorque()
    {
        return Random.Range(-maxTorque, maxTorque);
    }

    Vector3 randomSpawnPos()
    {
        return new Vector3(Random.Range(-xRange, xRange), -yPos);
    }

    private void OnMouseDown()
    {
        if (gameManager.isGameActive)
        {
            Destroy(gameObject);
            Instantiate(explosionParticle, transform.position, transform.rotation);
            gameManager.updateScore(pointValue);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        if (!gameObject.CompareTag("Bad"))
        {
            gameManager.gameOver();
        }
    }
}
