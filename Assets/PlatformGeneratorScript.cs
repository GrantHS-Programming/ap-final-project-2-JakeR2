using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGeneratorScript : MonoBehaviour
{
    public GameObject platform;
    public float spawnRate = 2;
    private float timer = 0;
    public float horizontalOffSet = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnPlatform();
            timer = 0;
        }
    }
    void spawnPlatform()
    {
        float leftMostPoint = transform.position.x - horizontalOffSet;
        float rightMostPoint = transform.position.x + horizontalOffSet;
        Instantiate(platform, new Vector3(Random.Range(leftMostPoint, rightMostPoint), transform.position.y, 0), transform.rotation);
    }
}
