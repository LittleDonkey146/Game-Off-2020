using System.Collections;
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

    private bool playSFX = false; // Used in order to play the footstep soundFX

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

        // Footsteps Sound FX part
        if (moveInput != 0 && playSFX == false && isGrounded == true)
        {
            playSFX = true;
            _audioSource.clip = footstep;
            StartCoroutine(PlaySFX());
        }
        else if(isGrounded == false)
        {
            playSFX = false;
        }
        else if (moveInput == 0 && playSFX == true)
        {
            playSFX = false;
        }
        // Ends here

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
            rb.velocity = Vector2.up * jumpForce;
            extraJump--;

            // Jumping Sound FX
            //_audioSource.clip = jump1;
            
            StartCoroutine(PlaySFX());
            
        }
        else if (Input.GetKeyDown(KeyCode.Space) && extraJump == 0 && isGrounded == true)
        {
            rb.velocity = Vector2.up * jumpForce;

        }
    }

    public IEnumerator PlaySFX()
    {
        while (playSFX && isGrounded == true)
        {
            _audioSource.Play();
            yield return new WaitForSeconds(0.5f);
        }

        if(isGrounded == false && Input.GetKeyDown(KeyCode.Space))
        {
            _audioSource.clip = jump1;
            _audioSource.Play(); // WORK NEEDS TO BE DONE IN ORDER TO PLAY THE SECOND JUMP SOUND AS WELL
        }
    }

    /*public IEnumerator FootstepSFX() // Footsteps Sound FX
    {
        while (playSFX == true)
        {
            footstep.Play();
            yield return new WaitForSeconds(0.3f);

        }

    }

    public IEnumerator Jump1SFX() // Jump 1 Sound FX
    {
        if (isGrounded == true)
        {
            jump1.Play();
            yield return null;
        }
        else
        {
            StartCoroutine(Jump2SFX());
        }
    }

    public IEnumerator Jump2SFX() //Jump 2 Sound FX
    {
        yield return null;
        jump2.Play();
    }*/

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