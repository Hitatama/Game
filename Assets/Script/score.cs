using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    int hits = 0;
    public int maxHealth = 100;  // Health Point maksimum
    private int currentHealth;   // Health Point saat ini
    public Transform respawnPoint; // Posisi respawn jika Health Points habis
    public Text healthText; // Referensi ke UI Text


    private void Start()
    {
        currentHealth = maxHealth;
        healthText.text = "Health: " + currentHealth.ToString();
    }


    void Respawn()
    {
        // Mengatur posisi objek ke respawnPoint
        transform.position = respawnPoint.position;
        transform.rotation = respawnPoint.rotation;

    }


    private void OnCollisionEnter(Collision other)
    {
       if (other.gameObject.tag != "Hit")
        {
            hits = 1;
            currentHealth -= hits; // Mengurangi Health Points
            healthText.text = "Health: " + currentHealth.ToString();
            
        }
            

        if (currentHealth <= 0)
        {
            currentHealth = maxHealth; // Reset Health Points jika habis
            Respawn(); // Panggil fungsi respawn
        }


    }
    


}
