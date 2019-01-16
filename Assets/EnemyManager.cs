using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* In charge of spawning enemies
 */
public class EnemyManager : MonoBehaviour
{
    private float spawnInitialDelay = 30.0f;
    private float spawnInterval = 10.0f;

    // 2D arrays such that for object[x][y], x is the current game level and y is the types.
    public GameObject[][] enemyTypes;
    public Transform[][] gameSpawnPoints;

    // Start is called before the first frame update
    void Start() {
        InvokeRepeating("Spawn",spawnInitialDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update() {
        
    }

    // Currently, spawn is repeated spawning enemies 
    void Spawn() {
        //Delete return when we have non-empty arrays of enemies and spawn points
        //Uncommment the rest of the function after that
        return;

        /*
        if (GameControl.instance.gameState != GameState.RESUMED) {
            return;
        }

        int currentGameLevel = GameControl.instance.gameLevel;

        int spawnEnemyIndex = Random.Range(0, enemyTypes);
        int spawnPointIndex = Random.Range(0, gameSpawnPoints.Length);

        Instantiate(enemyTypes[currentGameLevel][spawnEnemyIndex], gameSpawnPoints[currentGameLevel][spawnPointIndex], true);
        */      
    }
}
