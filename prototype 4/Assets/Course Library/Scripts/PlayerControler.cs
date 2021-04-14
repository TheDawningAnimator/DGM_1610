using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    private Rigidbody playerRb;
    public float speed;
    private GameObject focalPoint;

    public bool hasPowerup;
    public float powerupStrength = 16;

    public GameObject powerupIndicator;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("focalPoint");
    }

    // Update is called once per frame
    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");
        playerRb.AddForce(focalPoint.transform.forward * speed * Time.deltaTime);

        powerupIndicator.transform.position = transform.position + new Vector3(0, 0.5f, 0);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("powerup"))
        {
            hasPowerup = true;
            Destroy(other.gameObject);
            Debug.Log("powered up");

            StartCoroutine(PowerupCountdownRoutine());
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("enemy") && hasPowerup)
        {
            //gets enemy rigidbody so we can acces properties
            Rigidbody enemyRigidbody = collision.gameObject.GetComponent<Rigidbody>();
            //gets enemy position in relation to layer
            Vector3 awayFromPlayer = (collision.gameObject.transform.position - transform.position);
            //
            Debug.Log("player has collided with " + collision.gameObject + "with powerup set to" + hasPowerup);
            //on collition kicks enemy back
            enemyRigidbody.AddForce(awayFromPlayer * powerupStrength, ForceMode.Impulse);
        }
    }

    IEnumerator PowerupCountdownRoutine()
    {
        yield return new WaitForSeconds(7); hasPowerup = false;
        powerupIndicator;
    }
}
