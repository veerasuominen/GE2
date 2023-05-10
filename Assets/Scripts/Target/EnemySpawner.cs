using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    public float spawnFreq = 1;
    public float spawnDistance = 25f;

    // Start is called before the first frame update
    private void Start()
    {
        StartCoroutine(SpawnEnemies(spawnFreq, enemy));
    }

    private IEnumerator SpawnEnemies(float freq, GameObject enemy)
    {
        yield return new WaitForSeconds(spawnFreq);
        GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-25f, 25f), 1.5f, Random.Range(-25f, 25f)), Quaternion.identity);
        StartCoroutine(SpawnEnemies(freq, enemy));
    }
}