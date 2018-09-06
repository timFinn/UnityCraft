using UnityEngine;
using System.Collections;

public class SpawnEnemies : MonoBehaviour
{

    public GameObject player;
    public GameObject enemyPrefab;

    private Quaternion enemyDirection;

    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        enemyDirection = Quaternion.LookRotation(player.transform.position);
        InvokeRepeating("SpawnEnemy", 3.0f, 10.0f);

    }

    void SpawnEnemy()
    {
        Vector3 spawnPos = new Vector3(Random.Range(2.0f, 5.0f), 20.0f, Random.Range(2.0f, 5.0f));
        Instantiate(enemyPrefab, spawnPos, enemyDirection);
    }
}
