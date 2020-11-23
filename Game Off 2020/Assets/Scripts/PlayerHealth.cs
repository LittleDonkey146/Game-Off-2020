using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerHealth : MonoBehaviour
{

    public float health = 10000f;
    //public float damage;

    public TextMeshProUGUI text;

    //public Text text;
    private string healthtext;

    public GameObject lavaDrops;

    private void Update()
    {
        ShowHealth();
    }

    private void ShowHealth()
    {
        healthtext = gameObject.GetComponent<PlayerHealth>().health.ToString();
        text.text = healthtext + " HP";
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
        SceneManager.LoadScene("Game Over Scene");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Lava Drops")
        {
            //TakeDamage(damage);
        }
    }
}
