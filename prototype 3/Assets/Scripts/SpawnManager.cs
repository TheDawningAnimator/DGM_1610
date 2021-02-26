using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obsticalPrefab;

    public float startDelay = 0.2f;

    public float repeatDelay = 
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating();
        Instantiate(obsticalPrefab, spawnPos, obsticalPrefab.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void spawnObstical();
}
