using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPlatformScript : MonoBehaviour
{
    private float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < 100)
        {
            timer = timer + Time.deltaTime;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (timer < 20)
        {
            if (collision.tag == "Platform")
            {
                Destroy(gameObject);
            }
        }
    }

}
