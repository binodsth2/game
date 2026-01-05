using UnityEngine;

public class BricksSpawner : MonoBehaviour
{
    [Header("Prefab")]
    [SerializeField] private GameObject bricksPrefab;

    [Header("Spawn Timing")]
    [SerializeField] private float spawnInterval = 3f;

    [Header("Vertical Spawn Range")]
    [SerializeField] private float minY = -1.5f;
    [SerializeField] private float maxY = 0.8f;

    private float spawnTimer;

    private void Start()
    {
        // Spawn immediately when the game starts
        spawnTimer = 0f;

        // Safety check to avoid runtime errors
        if (bricksPrefab == null)
        {
            Debug.LogError("BricksSpawner: Bricks Prefab is NOT assigned!");
        }
    }

    private void Update()
    {
        if (bricksPrefab == null) return;

        spawnTimer -= Time.deltaTime;

        if (spawnTimer <= 0f)
        {
            SpawnBricks();
            spawnTimer = spawnInterval;
        }
    }

    private void SpawnBricks()
    {
        Vector3 spawnPosition = transform.position;
        spawnPosition.y = Random.Range(minY, maxY);

        Instantiate(bricksPrefab, spawnPosition, Quaternion.identity);
    }

#if UNITY_EDITOR
    private void OnDrawGizmosSelected()
    {
        // Visualize spawn range in the editor
        Gizmos.color = Color.green;
        Vector3 top = new Vector3(transform.position.x, maxY, transform.position.z);
        Vector3 bottom = new Vector3(transform.position.x, minY, transform.position.z);
        Gizmos.DrawLine(top, bottom);
    }
#endif
}
