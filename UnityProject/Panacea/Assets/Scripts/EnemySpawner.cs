using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyObject;
    public float spawnTime=3f;
    private float timeBeforeSpawn;
    public float enemyVelocity = -5f;
    void Start()
    {
        timeBeforeSpawn = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeBeforeSpawn > 0) timeBeforeSpawn -= Time.deltaTime;
        SpawnEnemy();
    }

    void SpawnEnemy()
    {
        if (timeBeforeSpawn <= 0)
        {
            GameObject newEnemy = Instantiate(enemyObject,this.transform.position, Quaternion.identity);
            Rigidbody2D enemyRb2d = newEnemy.GetComponent<Rigidbody2D>();
            enemyRb2d.gravityScale = 0;
            enemyRb2d.velocity = new Vector2(0, enemyVelocity);
            timeBeforeSpawn = spawnTime;
        }
    }
}
