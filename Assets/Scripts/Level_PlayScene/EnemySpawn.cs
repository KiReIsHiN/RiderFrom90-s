using System.Collections;
using UnityEngine;
using GameParametr;

public class EnemySpawn : MonoBehaviour
{
    public GameObject[] enemies;
    public Transform[] SpawnPos;


    private void Start()
    {
        StartCoroutine(SpawnCD());
    }

    void Repeat()
    {
        StartCoroutine(SpawnCD());
    }

    IEnumerator SpawnCD()
    {
        yield return new WaitForSeconds(GameParametrs.spawnTime);
        Instantiate(enemies[Random.Range(0, enemies.Length)], SpawnPos[Random.Range(0, 4)].position, Quaternion.identity);
        Repeat();
    }
}
