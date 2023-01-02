using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Siin on kood, et vaenalne kukutaks asteroide

public class EnemyAttacking : MonoBehaviour
{
    public GameObject asteroidPrefab;
    public float spawnTimer;
    public float spawnMax = 8;
    public float spawnMin = 2;

    // Start is called before the first frame update
    void Start()
    {
        // et asteroid langeks suvalisest planeedist suvalisel ajal
        spawnTimer = Random.Range(spawnMin, spawnMax);
    }

    // Update is called once per frame
    void Update()

    {
        spawnTimer -= Time.deltaTime;
        if (spawnTimer <= 0)
        {
            // Kood, et asteroide langeks alla
            Instantiate(asteroidPrefab, transform.position, Quaternion.identity);

            // Reset Timer - et asteroide langeks peale kadumist veel ja veel
            spawnTimer = Random.Range(spawnMin, spawnMax);
        }


    }
}
