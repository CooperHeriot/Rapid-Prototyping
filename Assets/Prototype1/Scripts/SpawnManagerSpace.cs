using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerSpace : MonoBehaviour
{
    public GameObject enemyPrefab;

    public int enemyCount;
    public int waveNuber = 1;

    public GameObject powerupPrefab;

    public GameObject SpawnBox;

    void Start()
    {
        SpawnEnemyWave(waveNuber);

        Instantiate(powerupPrefab, SpawnBox.transform.position, powerupPrefab.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            randomRot();
        }

        enemyCount = FindObjectsOfType<Enemy>().Length;
        if (enemyCount == 0)
        {
            waveNuber++;
            Instantiate(powerupPrefab, SpawnBox.transform.position, powerupPrefab.transform.rotation);
            SpawnEnemyWave(waveNuber);
        }
    }

    void SpawnEnemyWave(int enemiesToSpawn)
    {
        for (int i = 0; i < enemiesToSpawn; i++)
        {
            randomRot();
            Instantiate(enemyPrefab, SpawnBox.transform.position, enemyPrefab.transform.rotation);
        }
    }

    public void randomRot()
    {
        transform.rotation = new Quaternion(Random.Range(-360, 360), Random.Range(-360, 360), Random.Range(-360, 360),1);
    }
}
