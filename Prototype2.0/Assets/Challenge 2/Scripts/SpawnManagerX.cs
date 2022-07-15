using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;
    

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float timer;

    private float minTime = 3.0f;
    private float maxTime = 5.0f;

    public float spawnTimeInterval;

    void Start()
    {
        spawnTimeInterval = Random.Range(minTime, maxTime);
    }
    void Update()
    {
        timer += Time.deltaTime;
        //spawn TimeInterval == Random.Range(minTime, maxTime);
        if (timer > spawnTimeInterval)
        {
            //call function
            SpawnRandomBall();
            //reset timer and spawn interval
            spawnTimeInterval = Random.Range(minTime, maxTime);
            timer = 0;
                
        }

    }
    void SpawnRandomBall()
    {

        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
        int ballIndex = Random.Range(0, ballPrefabs.Length);
        //Instantiate ball at random spawn location
        Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[ballIndex].transform.rotation);

    }




}
