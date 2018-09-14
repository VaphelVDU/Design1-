using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public int PlayerSpeed = 10;
    private bool FacingRight = false;
    public int PlayerJumpPower = 1250;
    private float MoveX;
    public bool isGrounded;
    public int maxJumps = 1;
    public int remainingJumps = 1;
    // Update is called once per frame

    void Update()
    {
        PlayerMove();
    }

    void PlayerMove()
    {
        //Controlls
        MoveX = Input.GetAxis("Horizontal");

        if (Input.GetButtonDown("Jump"))
        {

            if (isGrounded)
            {
                Jump();
                isGrounded = false;
            }
            else if (remainingJumps > 0)
            {
                Jump();

                remainingJumps--;
            }

        }
        //Animations
        //Player Direction
        if (MoveX < 0.0f && FacingRight == false)
        {
            FlipPlayer();
        }
        else if (MoveX > 0.0f && FacingRight == true)
        {
            FlipPlayer();
        }
        //Physics
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(MoveX * PlayerSpeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
    }

    void Jump()
    {
        //Jumping Code
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * PlayerJumpPower);
    }

    void FlipPlayer()
    {
        FacingRight = !FacingRight;
        Vector2 localScale = gameObject.transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        isGrounded = true;
        remainingJumps = maxJumps;
    }

}
