using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaDrops : MonoBehaviour
{

    public float damage;
    public float thrust = 5f;

    private Rigidbody2D rb2D;

    public ParticleSystem explosionParticles;

    private PlayerHealth _playerHealth;

    private void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        rb2D.AddForce(new Vector2(thrust, 0), ForceMode2D.Impulse);

        _playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();

    }

    private void Update()
    {
        Vector2 direction = rb2D.velocity;
        transform.rotation = Quaternion.LookRotation(direction);
    }

    public void DealDamage()
    {
        _playerHealth.TakeDamage(damage);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == 9) //Layer 8 is the ground and Layer 9 is the player.
        {
            DealDamage();

        }

        if (gameObject.tag == "Lava Drops")
        {
            Destroy(gameObject);
        }

        if (gameObject.tag == "Big Lava") // Used in order to wait for the particles effect to play properly
        {
            StartCoroutine(PlayParticles());
            Destroy(gameObject.GetComponent<MeshRenderer>());
            Destroy(gameObject.GetComponent<CapsuleCollider2D>());
            Destroy(gameObject.GetComponent<Rigidbody2D>());
        }

    }

    IEnumerator PlayParticles()
    {
        explosionParticles.Play();
        yield return new WaitForSeconds(2f);
        Destroy(gameObject);
    }

}
