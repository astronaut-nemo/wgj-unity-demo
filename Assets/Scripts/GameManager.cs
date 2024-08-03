using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject applePrefab;
    public float spawnRate = 2.0f;
    public bool isSpawnApple = true;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnApples());
    }

    // Coroutine to spawn apples
    IEnumerator SpawnApples() {
        while(isSpawnApple) {
            yield return new WaitForSeconds(spawnRate);
            Instantiate(applePrefab);
        }
    }
}
