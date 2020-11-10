using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaDrops : MonoBehaviour
{

    public float damage = 30f;
    public float thrust = 5f;

    private Rigidbody2D rb2D;

    public ParticleSystem explosionParticles;

    private void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        rb2D.AddForce(new Vector2(thrust, 0), ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == 8 || collision.gameObject.layer == 9) //Layer 8 is the ground and Layer 9 is the player.
        {
            //explosionParticles.Play();
            //NEEDS SOME FIXING IN ORDER TO PLAY THE EXPLOSION PARTICLES FOR THE BIG LAVA DROPS
            Destroy(gameObject);
        }
    }


}
