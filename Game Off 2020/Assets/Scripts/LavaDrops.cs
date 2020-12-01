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
        if (rb2D != null) // Used in order to stop if the big lava drops are destroyed so they do not return an error
        {

            Vector3 direction = rb2D.velocity;
            transform.rotation = Quaternion.LookRotation(new Vector3(direction.x - 90, direction.y, direction.z));

        }

    }

    public void DealDamage()
    {
        _playerHealth.TakeDamage(damage);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == 9) // Layer 9 is the player.
        {
            DealDamage();

        }

        if (gameObject.CompareTag("Lava Drops"))
        {
            Destroy(gameObject);
        }

        if (gameObject.CompareTag("Big Lava")) // Used in order to wait for the particles effect to play properly
        {
            StartCoroutine(PlayParticles());
            Destroy(gameObject.GetComponent<MeshRenderer>());
            Destroy(gameObject.GetComponent<CapsuleCollider2D>());
            Destroy(gameObject.GetComponent<Rigidbody2D>());
        }

    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.CompareTag("Human Goal"))
        {
            Destroy(gameObject);
        }
    }

    IEnumerator PlayParticles()
    {
        explosionParticles.Play();
        yield return new WaitForSeconds(2f);
        Destroy(gameObject);
    }

}
