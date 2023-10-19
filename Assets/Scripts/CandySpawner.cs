using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandySpawner : MonoBehaviour
{
    [SerializeField] float spawnCooldown = 2.0f;
    [SerializeField] int candyCount = 15;
    [SerializeField] GameObject candy;

    void Start()
    {
        // timer coroutine function
        StartCoroutine(SpawnCandy());
    }

    private IEnumerator SpawnCandy()
    {
        yield return new WaitForSeconds(spawnCooldown);

        Vector2 spawnPos = new Vector2(Random.Range(-10, 10), 0);

        if (candyCount > 0 ) 
        { 
            // instance candy and set spawn position
            Instantiate(candy).transform.position = spawnPos;
            candyCount--;
        }
        // Call self once terminated
        StartCoroutine(SpawnCandy());
    }
}
