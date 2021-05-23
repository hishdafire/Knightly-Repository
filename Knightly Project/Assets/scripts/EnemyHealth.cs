using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{


    public int startingHealth;

    int currentHealth;

    void Awake()
    {
        currentHealth = startingHealth;
    }

    public void HealthChange(int changeAmount)
    {
        currentHealth = currentHealth + changeAmount;

        currentHealth = Mathf.Clamp(currentHealth, 0, startingHealth);

        if (currentHealth == 0)
        {
            Kill();
        }
    }



    public void Kill()
    {
        Destroy(gameObject);
    }

    public int GetHealth()
    {
        return currentHealth;
    }

}
