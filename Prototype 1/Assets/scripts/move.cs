using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    // Access modifier, Data type, Name
    public float speed = 30.0f;

    private float turnspeed = 35.9f;


    public float hInput;

    public float fInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //gather inpt for controls
        hInput = Input.GetAxis("Horizontal");
        fInput = Input.GetAxis("Vertical");
        //makes player go back and forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * fInput);
        //makes player go left and right
        transform.Rotate(Vector3.up * turnspeed * hInput * Time.deltaTime);
    }
}
