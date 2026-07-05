using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [Header("References")]
    public GameObject pipePrefab;  

    [Header("Settings")]
    public float spawnRate = 2f;    
    public float heightOffset = 2f; 

    private float timer = 0f;

    void Start()
    {
        
        SpawnPipe();
    }

    void Update()
    {
        
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            
            SpawnPipe();
            timer = 0f;
        }
    }

    void SpawnPipe()
    {
        
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        
        float randomY = Random.Range(lowestPoint, highestPoint);

        
        Instantiate(pipePrefab, new Vector3(transform.position.x, randomY, 0), transform.rotation);
    }
}