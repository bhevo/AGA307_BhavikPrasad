using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform[] spawnPoints;
    public GameObject[] enemyTypes;
    public List<GameObject> enemies;
    void Start()
    {
        for (int i = 0; i < 100; i++)
        {
            Debug.Log((i + 1));
        }
        SpawnEnemy();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnEnemy()
    {
        for (int i = 0; i < enemyTypes.Length; i++)
        {
            int spawnIndex = Random.Range(0, spawnPoints.Length);
           GameObject newSpawn = Instantiate(enemyTypes[i], spawnPoints[spawnIndex].position + Random.insideUnitSphere * 2.0f, spawnPoints[spawnIndex].rotation);
            enemies.Add(newSpawn);
            Debug.Log(enemies.Count);


        }
        Debug.Log("Total: " + enemies.Count + " Enemies");
    }
}