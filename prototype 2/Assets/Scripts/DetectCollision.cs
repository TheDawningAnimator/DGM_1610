using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
   
    void OnTriggerEnter(Collider other)
    {
        //destory what script is on
        Destroy(gameObject);
        //destroy other object hits a trigger
        Destroy(other.gameObject);
    }
}
