using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float hInput;
    public float speed = 20.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxis("Horizontal");
        if (transform.position.x < -15)
            transform.position = new Vector3(-15, transform.position.y, transform.position.z);
        transform.Translate(Vector3.right * hInput * Time.deltaTime * speed);
    }
}
