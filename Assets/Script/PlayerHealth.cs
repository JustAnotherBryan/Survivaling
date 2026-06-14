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
            healthSlider.minValue = 0;
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
        if (Input.GetMouseButtonDown(0))
        {
            TakeDamage(10);
            Debug.Log(currentHealth);
        }

        if (Input.GetMouseButtonDown(1))
        {
            Heal(10);
            Debug.Log(currentHealth);
        }

        if (Input.GetKeyDown("space"))
        {
            maxHealth += 10;
            Debug.Log(maxHealth);  
            healthSlider.maxValue = maxHealth;
        }
    } 

}
