using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
#pragma warning disable CS0108 // Member hides inherited member; missing new keyword
    public Rigidbody2D rigidbody2D;
#pragma warning restore CS0108 // Member hides inherited member; missing new keyword
    public int runSpeed = 5000;
    public int jumpForce = 5;
    private bool canJump;
    private float horizontal;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Jumping Movement
        if (Input.GetKeyDown(KeyCode.W) && canJump)
        {
            rigidbody2D.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);

        }

        if (Input.GetKeyDown(KeyCode.Joystick1Button0) && canJump)
        {
            rigidbody2D.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }

        horizontal = Input.GetAxisRaw("Horizontal");

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            gameObject.transform.localScale = new Vector3(-13, 13, 13);

        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            gameObject.transform.localScale = new Vector3(13, 13, 13);

        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            gameObject.transform.localScale = new Vector3(-13, 13, 13);

        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            gameObject.transform.localScale = new Vector3(13, 13, 13);

        }
    }

    // Horizontal Movement

    private void FixedUpdate()
    {
        rigidbody2D.velocity = new Vector2(horizontal * runSpeed * Time.deltaTime, rigidbody2D.velocity.y);
    }

    // Allowing to jump/climb on objects labeled as "Ground"

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            canJump = false;
        }

        if (collision.gameObject.CompareTag("Climb"))
        {
            canJump = false;
        }

    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            canJump = true;
        }

        if (collision.gameObject.CompareTag("Climb"))
        {
            canJump = true;
        }
    }

}

