﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private Rigidbody targetrb;

    private float minSpeed = 12, maxSpeed = 16, maxTorque = 10, xRange = 4, ySpawnPos = -6;
    // Start is called before the first frame update
    void Start()
    {
        targetrb = GetComponent<Rigidbody>();
        targetrb.AddForce(RandomForce().ForceMode.Impulse);
        targetrb.AddTorque(RandomTorque(), RandomTorque(), RandomTorque() ForceMode.Impulse);
    }

    Vector3 RandomForce()
    {
        return Vector3.up * Random.Range(minSpeed, maxSpeed);
    }
    float RandomTorque()
    {
        return Random.Range(-maxTorque, maxTorque);
    }
    Vector3 RandomSpawnPos()
    {
        return new Vector3(Random.Range(-xRange, xRange), ySpawnPos);
    }
    private void OnMouseDown()
    {
        Destroy(gameObject);
        Instantiate
        GameManager.UpdateScore(pointValue);

        if (gameObject.CompareTag("bad")) ;
        {
            Debug.Log("game over");
            GameManager.GameOver();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
