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
    private Collider2D coll;
    private bool facingRight = true; 

    private bool isGrounded;
    public Transform groundCheck;
    public float checkRadious;
    public LayerMask whatIsGround;
    public LayerMask otherGround; //layer for the destructable objects

    private int extraJump;
    public int extraJumpValue;

    //private bool isPlaying = false;

    public AudioSource _audioSource;
    public AudioClip jump1;
    public AudioClip jump2;
    public AudioClip footstep;

    public Animator anim;
    private enum State {idle, running, jumping, falling, doubleJumping, pickingUp};
    private State state = State.idle;
    private int cont = 0;
    private bool varDoubleJumping;
    private bool isPickingUp;

    void Start()
    {
        extraJump = extraJumpValue;
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<Collider2D>();

        //StartCoroutine(PlaySoundsCoroutine());
    }

    void FixedUpdate() 
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadious, whatIsGround);

        moveInput = Input.GetAxisRaw("Horizontal"); 
        rb.velocity = new Vector2(moveInput * velocita, rb.velocity.y);

        //_audioSource.clip = footstep;

    }

    void Update()
    {
        Movement();

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

            cont++;
        }

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded == false && cont > 0)
        {
            cont = 0;
            _audioSource.clip = jump2;
            _audioSource.Play();

            varDoubleJumping = true;

            _audioSource.loop = false;
        }
        else 
        {
            varDoubleJumping = false;
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

    public void Movement()
    {
        if (!Input.GetKeyDown(KeyCode.F) && state != State.pickingUp)
        {
            if (facingRight == false && moveInput > 0)
            {
                state = State.running;
                anim.SetInteger("state", (int)state);
                Flip();
            }

            if (facingRight == true && moveInput < 0)
            {
                state = State.running;
                anim.SetInteger("state", (int)state);
                Flip();
            }

            if (!coll.IsTouchingLayers(whatIsGround) && !coll.IsTouchingLayers(otherGround) && varDoubleJumping == false)
            {
                state = State.jumping;
                anim.SetInteger("state", (int)state);

                if (!coll.IsTouchingLayers(whatIsGround) && !coll.IsTouchingLayers(otherGround) && varDoubleJumping == true)
                {
                    state = State.doubleJumping;
                    anim.SetInteger("state", (int)state);
                }
            }
            else if (moveInput == 0)
            {
                state = State.idle;
                anim.SetInteger("state", (int)state);
            }
            else
            {
                state = State.running;
                anim.SetInteger("state", (int)state);
            }
        }
        else 
        {
            if (state != State.running && state != State.jumping && state != State.doubleJumping) 
            {
                state = State.pickingUp;
                anim.SetInteger("state", (int)state);
                StartCoroutine(ExampleCoroutine());
            }
        }

    }

    IEnumerator ExampleCoroutine()
    {
        yield return new WaitForSeconds(0.5f);

        state = State.idle;
    }

    private void Flip()
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