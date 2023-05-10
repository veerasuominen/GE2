using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public float health = 100;
    public float amount = 10;

    private void OnTriggerEnter(Collider other)
    {
        TakeDamage(amount);
    }

    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        SceneManager.LoadScene(0);
    }
}