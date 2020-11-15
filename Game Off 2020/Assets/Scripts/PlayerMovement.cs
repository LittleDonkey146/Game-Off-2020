﻿using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float velocita = 5f; 
    public float jumpForce = 10f; 
    private float moveInput; 
    private Rigidbody2D rb; 
    private bool facingRight = true; 

    private bool isGrounded;
    public Transform groundCheck;
    public float checkRadious;
    public LayerMask whatIsGround;

    private int extraJump;
    public int extraJumpValue;

    public AudioSource _audioSource;
    public AudioClip jump1;
    public AudioClip jump2;
    public AudioClip footstep;

    void Start()
    {
        extraJump = extraJumpValue;
        rb = GetComponent<Rigidbody2D>(); 
    }

    void FixedUpdate() 
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadious, whatIsGround);

        moveInput = Input.GetAxisRaw("Horizontal"); 
        rb.velocity = new Vector2(moveInput * velocita, rb.velocity.y);

        if (facingRight == false && moveInput > 0) 
        {
            Flip(); 
        }
        else if (facingRight == true && moveInput < 0) 
        {
            Flip(); 
        }

    }

    void Update()
    {

        if (isGrounded == true)
        {
            extraJump = extraJumpValue;
        }

        if (Input.GetKeyDown(KeyCode.Space) && extraJump > 0)
        {
            extraJump--;

            rb.velocity = Vector2.up * jumpForce;
        }
    }

    void Flip()
    {

        facingRight = !facingRight;

        if (facingRight)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        else
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }

    }
}