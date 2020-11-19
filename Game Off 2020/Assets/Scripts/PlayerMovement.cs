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

    private bool isPlaying = false;

    public AudioSource _audioSource;
    public AudioClip jump1;
    public AudioClip jump2;
    public AudioClip footstep;

    public Animator anim;

    void Start()
    {
        extraJump = extraJumpValue;
        rb = GetComponent<Rigidbody2D>();

        //StartCoroutine(PlaySoundsCoroutine());
    }

    void FixedUpdate() 
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadious, whatIsGround);

        moveInput = Input.GetAxisRaw("Horizontal"); 
        rb.velocity = new Vector2(moveInput * velocita, rb.velocity.y);

        //_audioSource.clip = footstep;
        Debug.Log(moveInput);

        if (facingRight == false && moveInput > 0)
        {
            anim.SetBool("running", true);           
            Flip();
        }
        
        if (facingRight == true && moveInput < 0)
        {
            anim.SetBool("running", true);         
            Flip();
        }

        if (moveInput == 0)
        {
            anim.SetBool("running", false);
        }
        else 
        {
            anim.SetBool("running", true);
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
            _audioSource.clip = jump1;
            _audioSource.Play();
            extraJump--;

            _audioSource.loop = false;

            
            rb.velocity = Vector2.up * jumpForce;

        }

        if (_audioSource.isPlaying == false && isGrounded == true && moveInput != 0)
        {
            _audioSource.clip = footstep;
            _audioSource.loop = true;

            _audioSource.Play();
        }
        else if (_audioSource.isPlaying == true && isGrounded == true && moveInput == 0)
        {
            _audioSource.loop = false;
            _audioSource.clip = jump1;

        }
    }

    public void PlaySFX()
    {
        _audioSource.Play();
    }

    /*public IEnumerator PlaySoundsCoroutine()
    {
        while ( SOMETHING )
        {
            PlaySFX();
            yield return new WaitForSeconds(0.5f);
        }
        
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