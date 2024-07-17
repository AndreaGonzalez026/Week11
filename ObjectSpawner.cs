using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject objectPrefab;
    public float spawnInterval = 2f;

    private void Start()
    {
        InvokeRepeating("SpawnObject", 1f, spawnInterval);
    }

    private void SpawnObject()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(-5f, 5f), -5f, 0f);
        Instantiate(objectPrefab, spawnPosition, Quaternion.identity);
    }
}
