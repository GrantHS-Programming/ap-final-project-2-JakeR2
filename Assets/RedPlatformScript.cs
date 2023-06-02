using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RedPlatformScript : MonoBehaviour
{
    public GameObject platform;
    public int chunkSize;
    public int numChunks;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Platform")
        {
            Destroy(gameObject);
            Instantiate(platform, new Vector3(Random.Range((float)(-1.6), (float)(1.6)), Random.Range(0, numChunks * chunkSize), 0), transform.rotation);
        }
    }

    public void MakingPlatform()
    {
        
    }
    public RedPlatformScript()
    {
        MakingPlatform();
    }
}
