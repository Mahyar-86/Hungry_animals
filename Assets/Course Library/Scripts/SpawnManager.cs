using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs1;
    public GameObject[] animalPrefabs2;
    private float spawnRangeX1 = 33;
    private float spawnRangeX2 = 31;
    private float spawnRangeZ = 14;
    private float spawnPosZ = 25;
    private float spawnPosX = 48;
    private float startDelay1 = 1;
    private float spawnInterval1 = 5;
    private float startDelay2 = 2;
    private float spawnInterval2 = 10;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal1", startDelay1, spawnInterval1);
        InvokeRepeating("SpawnRandomAnimal2", startDelay2, spawnInterval2);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomAnimal1()
    {
        int animalIndex1 = Random.Range(0, animalPrefabs1.Length);
        Vector3 spawnPos1 = new Vector3(Random.Range(-spawnRangeX2, spawnRangeX1), 0, spawnPosZ);
        Instantiate(animalPrefabs1[animalIndex1], spawnPos1, animalPrefabs1[animalIndex1].transform.rotation);
    }
    void SpawnRandomAnimal2()
    {
        int animalIndex2 = Random.Range(0, animalPrefabs2.Length);
        Vector3 spawnPos2 = new Vector3(spawnPosX, 0, Random.Range(-spawnRangeZ, spawnRangeZ));
        Instantiate(animalPrefabs2[animalIndex2], spawnPos2, animalPrefabs2[animalIndex2].transform.rotation);
    }
}
