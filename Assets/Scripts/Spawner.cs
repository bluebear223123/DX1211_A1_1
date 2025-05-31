using System.Security.Cryptography;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject spawnObject;
    [SerializeField] float startTime = 0.0f;
    [SerializeField] float spawnEvery = 3.0f;
    [SerializeField] float lifeTime = 3.0f;

    BoxCollider2D Spawnbox;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        Spawnbox = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    Vector3 GetRandomPosition (Vector3 minBound, Vector3 maxBound) {
        float x = Random.Range(minBound.x, maxBound.x);
        float y = Random.Range(minBound.y, maxBound.y);

        return new Vector3(x, y, 0);
    }

    public void SpawnNew() {
        Bounds bounds = Spawnbox.bounds;
        Vector3 spawnPos = GetRandomPosition(bounds.min, bounds.max);

        var newSpawn = Instantiate(spawnObject);
        newSpawn.transform.position = spawnPos;
        newSpawn.SetActive(true);

        Destroy(newSpawn, lifeTime);
    }

    void Start()
    {
        InvokeRepeating("SpawnNew", startTime, spawnEvery);   
    }
}
