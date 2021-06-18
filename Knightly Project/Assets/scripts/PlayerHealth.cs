using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{

 
    public int startingHealth;
    public string gameOverScene;

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
        SceneManager.LoadScene(gameOverScene);
    }

    public int GetHealth()
    {
        return currentHealth;
    }

}
