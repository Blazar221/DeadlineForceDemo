using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject enemy;

    private GameObject newEnemy;
    private SpriteRenderer rend;
    private int randomSpawnZone;
    private float randXPos, randYPos;
    private Vector3 spawnPosition;
    
    // Start is called before the first frame update
    void Start() {
        InvokeRepeating("SpawnNewEnemy", 0f, 2f);
    }

    private void SpawnNewEnemy() {
        
        randomSpawnZone = 3;
        switch (randomSpawnZone)  {
            case 0:
                randXPos = Random.Range(-11f, -10f);
                randYPos = Random.Range(-8f, 8f);
                randYPos = -8f;
                break;
            case 1:
                randXPos = Random.Range(-10f, -10f);
                randYPos = Random.Range(-7f, -8f);
                break;
            
            case 2:
                randXPos = Random.Range(10f, 11f);
                randYPos = Random.Range(-8f, 8f);
                break;
            // curently only use this
            case 3:
                randXPos = Random.Range(-3f, 3f);
                randYPos = Random.Range(7f, 8f);
                break;
        }

        spawnPosition = new Vector3(randXPos, randYPos, 0);
        newEnemy = Instantiate(enemy, spawnPosition, Quaternion.identity);
        rend = newEnemy.GetComponent<SpriteRenderer>();
        rend.color = new Color(Random.Range(0,2), Random.Range(0,2), Random.Range(0,2), 1f);
    }
    
    // Update is called once per frame
    void Update() {
        
    }
}
