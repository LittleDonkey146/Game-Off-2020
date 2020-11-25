using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerHealth : MonoBehaviour
{

    public float health = 10000f;

    public TextMeshProUGUI text;

    private string healthtext;

    public GameObject lavaDrops;

    public AudioSource audioSource;
    public AudioClip damageAudio;
    public AudioClip healthAlert;

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

        //this is if a lava bullet hit the player
        if (audioSource.clip != healthAlert) 
        {
            audioSource.clip = damageAudio;
            audioSource.Play();

        }

        //this if the health is below like 9500
        if (health < 9500 /*&& playIt == true*/) 
        {
            audioSource.clip = healthAlert;
            audioSource.Play();

        }  

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
}
