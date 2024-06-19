using System.Collections;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;







public class Movement : MonoBehaviour
{

    private float horizontal;
    private float speed = 18f;
    private float jumpingpower = 40f;
    private bool idfacingright = true;

    [SerializeField] private Rigidbody2D rb;

    [SerializeField] private Transform grozundsheck;
    [SerializeField] private LayerMask Bodenlayer;




    private void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");

        if(Input.GetButtonDown("Jump") && IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpingpower);

        }
        if (Input.GetButtonDown ("Jump") && rb.velocity.y > 0f)
        {
            rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y * 0, 5f);
        }



        flip();



    }


    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(grozundsheck.position, 0.2f, Bodenlayer);
    }
    

    private void flip()
    {
        if (idfacingright && horizontal < 0f || !idfacingright && horizontal > 0f)
        {
            idfacingright = !idfacingright;
            Vector3 LocalScale = transform.localScale;

            LocalScale.x *= -1f;
            transform.localScale = LocalScale;

        }
    }




}

