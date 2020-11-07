using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    public float health = 100f;

    public GameObject lavaDrops;
    public float damage;

    private void Start()
    {
        damage = lavaDrops.GetComponent<LavaDrops>().damage;
        //damage = lavaDrops.damage;
    }

    private void Update()
    {
        
    }

    public void TakeDamage(float damageTaken)
    {
        health -= damageTaken;
        if (health <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Lava Drops")
        {
            TakeDamage(damage);
        }
    }
}
