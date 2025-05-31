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
    void Start()
    {
        Spawnbox = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Random.Range(1, 4);
    }
}
