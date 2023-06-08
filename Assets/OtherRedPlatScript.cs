using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherRedPlatScript : MonoBehaviour
{
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
        }
    }
}
