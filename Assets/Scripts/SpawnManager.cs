using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float startDelay = 2f;
    private float spawnInterval = 1.5f;

    private void Start() {
        InvokeRepeating(nameof(CreateRandomAnimal), startDelay, spawnInterval);
    }

    void Update()
    {
       
    }

    void CreateRandomAnimal() {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPosition = new Vector3(Random.Range(-20, 20), 0, 75);
        Instantiate(animalPrefabs[animalIndex], spawnPosition, animalPrefabs[animalIndex].transform.rotation);
    }
}
