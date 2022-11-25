using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] enemyPrefabs;
    private float startDelay = 0.5f;
    private float spawnInterval = 1;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomEnemy", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void SpawnRandomEnemy()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-25, 25),
                0, 10);

        Vector3 spawnPos1 = new Vector3(Random.Range(-25, 25),
                0, 0);

        int enemyIndex = Random.Range(0, enemyPrefabs.Length);
        Instantiate(enemyPrefabs[enemyIndex], spawnPos,
            enemyPrefabs[enemyIndex].transform.rotation);


    }


}
