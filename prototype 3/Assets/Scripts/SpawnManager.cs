using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obsticalPrefab;

    public float startDelay = 2.0f;

    public float repeatRate = 2.0f;

    private PlayerControler PCS;

    private Vector3 spawnPos = new Vector3(25, 0, 0);

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnObstical", startDelay, repeatRate);
        PCS = GameObject.Find("player").GetComponent<PlayerControler>();
    }
    void spawnObstical()
    { if (PCS.isGameOver == true)
        {
            Instantiate(obsticalPrefab, spawnPos, obsticalPrefab.transform.rotation);
        }
        
    }
 
}
