using System;
using UnityEngine;
using Object = UnityEngine.Object;
using Random = UnityEngine.Random;

public class MeteorGenerator : MonoBehaviour
{
    
    [SerializeField] private GameObject[] meteorPrefabs;
    [SerializeField] private float meteorSpawnDelay = 1f;
    
    private float currentMeteorSpawnDelay = 0f;
    
    private void Start()
    {
        SpawnMeteor();
    }

    private void Update()
    {
        currentMeteorSpawnDelay += Time.deltaTime;

        if (currentMeteorSpawnDelay >= meteorSpawnDelay)
        {
            SpawnMeteor();
            currentMeteorSpawnDelay = 0;
        }
    }

    private void SpawnMeteor()
    {
        GameObject meteor = Instantiate(GetRandomTypeOfMeteor(), GetSpawnPosition(), Quaternion.identity);

        meteor.GetComponent<MeteorMovement>().GetDirection();
        
        Destroy(meteor, 20f);
    }

    private GameObject GetRandomTypeOfMeteor()
    {
        GameObject randomMeteorPrefab = meteorPrefabs[Random.Range(0, meteorPrefabs.Length)];
        return randomMeteorPrefab;
    }

    Vector2 GetSpawnPosition()
    {
        float offset = 2f;
        Vector2 spawnPos = Vector2.zero;
        int side = Random.Range(0, 4); // 0 = top, 1 = bottom, 2 = left, 3 = right

        Camera cam = Camera.main;
        float camHeight = 2f * cam.orthographicSize;
        float camWidth = camHeight * cam.aspect;

        switch (side)
        {
            case 0: // top
                spawnPos = new Vector2(Random.Range(-camWidth/2, camWidth/2), camHeight/2 + offset);
                break;
            case 1: // bottom
                spawnPos = new Vector2(Random.Range(-camWidth/2, camWidth/2), -camHeight/2 - offset);
                break;
            case 2: // left
                spawnPos = new Vector2(-camWidth/2 - offset, Random.Range(-camHeight/2, camHeight/2));
                break;
            case 3: // right
                spawnPos = new Vector2(camWidth/2 + offset, Random.Range(-camHeight/2, camHeight/2));
                break;
        }

        return spawnPos;
    }

    
}
