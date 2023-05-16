using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClownScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float jumpStrength;
    public bool touchingPlatform = false;
    public float moveStrength;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (touchingPlatform)
        {
            myRigidbody.velocity = Vector2.up * jumpStrength;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            myRigidbody.velocity = Vector2.right * moveStrength;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            myRigidbody.velocity = Vector2.left * moveStrength;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        touchingPlatform = true;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        touchingPlatform = false;
    }
}
