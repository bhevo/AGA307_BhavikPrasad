using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class TargetManager : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] targetTypes;
    public List<GameObject> targets;
    // Start is called before the first frame update
    void Start()
    {
       // SpawnTarget();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            SpawnTarget();
        }
    }
    public void SpawnTarget()
    {
        for (int i = 0; i < targetTypes.Length; i++) 
        {
            int spawnIndex = Random.Range(0, spawnPoints.Length);
            GameObject newSpawn = Instantiate(targetTypes[i], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
            targets.Add(newSpawn);
            Debug.Log(targets.Count);
        }
        Debug.Log("Total: " + targets.Count + " Targets");
    }
}
