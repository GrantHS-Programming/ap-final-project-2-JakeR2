using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClownScript : MonoBehaviour
{
    private float horizontal;
    private float speed = 8f;
    private float jumpingPower = 13f;
    private bool isFacingRight = true;
    public float swapHorizontalAt;
    public float justUnderSwapHorizontalAt;

    public float maxHeight = 0;
    public LogicScript logic;
    public float scoreMultiplier = 0;

    public GameObject gameOverScreen;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > maxHeight)
        {
            maxHeight = transform.position.y;
            logic.addScore((int)(scoreMultiplier * maxHeight));
        }
        if (transform.position.y < maxHeight-5)
        {
            gameOverScreen.SetActive(true);
        }
        horizontal = Input.GetAxisRaw("Horizontal");

        if (IsGrounded() && rb.velocity.y <= 0)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
        }

        Flip();

        if (transform.position.x > swapHorizontalAt)
        {
            transform.position = new Vector3(-justUnderSwapHorizontalAt, transform.position.y, transform.position.z);
        }
        if (transform.position.x < -swapHorizontalAt)
        {
            transform.position = new Vector3(justUnderSwapHorizontalAt, transform.position.y, transform.position.z);
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }

    private void Flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }
}
