using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update

    private Rigidbody playerRB;
    private GameObject focalPoint;
    private float powerUpStrenght = 15.0f;
    private float speed = 5.0f;
    public bool hasPowerUp = false;
    public GameObject PowerupIndicator;
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("Focal Point");
    }

    private void OnTriggerEnter(Collider other) 
    { 
        if (other.CompareTag("PowerUp"))
        {
            hasPowerUp = true;
            PowerupIndicator.gameObject.SetActive(true);
            Destroy(other.gameObject);
            StartCoroutine(PowerupCountdownRoutine());
        }
    }

    private void OnCollisionEnter(Collision collision)
    { 
        if (collision.gameObject.CompareTag("Enemy") && hasPowerUp)
        {
            Rigidbody enemyRigiBody = collision.gameObject.GetComponent<Rigidbody>();
            Vector3 awayFromPlayer = collision.gameObject.transform.position - transform.position;

            enemyRigiBody.AddForce(awayFromPlayer * powerUpStrenght, ForceMode.Impulse);
            Debug.Log("Player collided with " + collision.gameObject + " with powerUp set to " + hasPowerUp);
        }
    }

    IEnumerator PowerupCountdownRoutine()
    {
        yield return new WaitForSeconds(7);
        hasPowerUp = false;
        PowerupIndicator.gameObject.SetActive(false);
    }


    // Update is called once per frame
    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");

        playerRB.AddForce(focalPoint.transform.forward * forwardInput * speed);

        PowerupIndicator.transform.position = transform.position + new Vector3(0,-0.5f,0);
    }
}
