using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGeneratorScript : MonoBehaviour
{
    public GameObject platform;
    public float spawnRate = 2;
    private float timer = 0;
    public float horizontalOffSet = 10;

    public int numChunks;
    public int platformsPerChunk;
    public int chunkSize;
    // Start is called before the first frame update
    void Start()
    {
        float leftMostPoint = transform.position.x - horizontalOffSet;
        float rightMostPoint = transform.position.x + horizontalOffSet;
        for (float i = 0; i < numChunks; i++)
        {
            for (int k = -1; k < platformsPerChunk; k++)
            {
                Instantiate(platform, new Vector3(Random.Range(leftMostPoint, rightMostPoint), Random.Range(i * chunkSize, (i + 1) * chunkSize), 0), transform.rotation);
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        float leftMostPoint = transform.position.x - horizontalOffSet;
        float rightMostPoint = transform.position.x + horizontalOffSet;
        if (timer < 100)
        {
            timer = timer + Time.deltaTime;
        }
        if (timer == 50)
        {
            for (float i = 0; i < numChunks; i++)
            {
                for (int k = -1; k < platformsPerChunk; k++)
                {
                    Instantiate(platform, new Vector3(Random.Range(leftMostPoint, rightMostPoint), Random.Range(i * chunkSize, (i + 1) * chunkSize), 0), transform.rotation);
                }
            }
        }
        if (timer == 100)
        {
            for (float i = 0; i < numChunks; i++)
            {
                for (int k = -1; k < platformsPerChunk; k++)
                {
                    Instantiate(platform, new Vector3(Random.Range(leftMostPoint, rightMostPoint), Random.Range(i * chunkSize, (i + 1) * chunkSize), 0), transform.rotation);
                }
            }
        }
    }
}
