using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    [SerializeField] private Slider healthSlider;

    void Start()
    {
        currentHealth = maxHealth;
        
        // Initialize slider min and max values
        if (healthSlider != null)
        {
            healthSlider.maxValue = maxHealth;
            healthSlider.value = currentHealth;
        }
    }


    // Call this method whenever the player takes damage
    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);

        UpdateHealthUI();
    }

    public void Heal(int healAmount)
    {
        currentHealth += healAmount;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);

        UpdateHealthUI();
    }

    private void UpdateHealthUI()
    {
        if (healthSlider != null)
        {
            healthSlider.value = currentHealth; // Bind health to slider value
        }
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Debug.Log("The left mouse button is being held down.");
            TakeDamage(10);
            Debug.Log(currentHealth);
        }

        if (Input.GetMouseButton(1))
        {
            Debug.Log("The right mouse button is being held down.");
            Heal(10);
            Debug.Log(currentHealth);
        }
    } 

}
