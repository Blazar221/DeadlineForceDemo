using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject obstacle;

    private Vector3 spawnPosition;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnNewObstacle", 0f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnNewObstacle(){
        float randXPos = Random.Range(-7f, 7f);

        Vector3 spawnPosition = new Vector3(randXPos, 4.5f, 0);
        GameObject newObstacle = Instantiate(obstacle, spawnPosition, Quaternion.identity);
    }
}
