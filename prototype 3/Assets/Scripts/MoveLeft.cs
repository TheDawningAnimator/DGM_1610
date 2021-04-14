using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed =30;
    private PlayerControler PCS;
    private float leftBound = -15f;
    // Start is called before the first frame update
    void Start()
    {
        //find and stores controler script for later
        PCS = GameObject.Find("player").GetComponent<PlayerControler>();
    }

    // Update is called once per frame
    void Update()
    {
        

        if (PCS.isGameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        if (transform.position.x < leftBound && gameObject.CompareTag("obstical"))
        {
            Destroy(gameObject);
        }
    }
}
