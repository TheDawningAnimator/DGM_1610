﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    // Access modifier, Data type, Name
    public float speed = 5.0f;

    public float hInput;

    public float fInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxis("Horizonal");
        fInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * fInput);
        transform.Translate(Vector3.right * Time.deltaTime * speed * hInput);
    }
}
