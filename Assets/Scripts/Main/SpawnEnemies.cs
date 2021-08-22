using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour {

    public GameObject[] enemies;
    public float spawnTime;
    public Transform[] SpawnPos;


    public GameObject road;
    private moveroad moverd;
    private float speed;

    private void Start()
    {
        StartCoroutine(SpawnCD());
    }

    void Repeat ()
    {
        StartCoroutine(SpawnCD());
    }

    IEnumerator SpawnCD()
    {
        yield return new WaitForSeconds(spawnTime);
        Instantiate(enemies[UnityEngine.Random.Range(0, 6)], SpawnPos[Random.Range(0,2)].position, Quaternion.identity);
        Repeat();
    }

    private void FixedUpdate()
    {
        moverd = road.GetComponent<moveroad>();
        speed = moverd.speed;

        if (speed < -0.05f)
        {
            spawnTime = 0.5f;
        }
    }
}
