using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    private Rigidbody playerRb;

    public float jumpForce;

    public float gravityMod;

    public bool isOnGround = true;

    public bool isGameOver = false;

    private Animator playerAnim;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityMod;

        playerAnim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
        
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !isGameOver == true)
        { 
         playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;

            playerAnim.SetTrigger("Jump_trig");
            
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }
        else if(collision.gameObject.CompareTag("Obsticle"))
        {
            isGameOver = true;
            Debug.Log("GAME OVER!!!");
            playerAnim.SetBool("Death_b",true);
            playerAnim.SetInteger("DeathType_int", 1);
        }
    }

}
