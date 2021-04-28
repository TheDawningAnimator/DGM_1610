using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float speed = 30.0f;

    private float xRange = 5;
    private float yRange = 10;

    public float hInput;

    public float fInput;
  
    // Update is called once per frame
    void Update()
    {
        //gather inpt for controls
        hInput = Input.GetAxis("Horizontal");
        fInput = Input.GetAxis("Vertical");
        //makes player go up and down
        transform.Translate(Vector3.left * Time.deltaTime * speed * fInput);
        //makes player go left and right
        transform.Translate(Vector3.up * hInput * speed * Time.deltaTime);

        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.z < -yRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -yRange);
        }
        if (transform.position.z > yRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, yRange);
        }
    }
}
