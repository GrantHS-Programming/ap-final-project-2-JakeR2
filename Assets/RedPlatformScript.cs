using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPlatformScript : MonoBehaviour
{
    public float downSpeed;
    public float deadZone;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3.down * downSpeed) * Time.deltaTime;

        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
    
}
