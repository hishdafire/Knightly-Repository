using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyHealth : MonoBehaviour
{


    public int health;
    public string winScene;

    public void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log(damage + " damage taken");


    }
    
    void Update()
    {
        if(health    <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene(winScene);
        }
    }
    



}
