using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class door : MonoBehaviour
{
    public string levelToLoad;

    void OnTriggerEnter2D(Collider2D otherCollider)
    {
        //Debug.Log("Object hit the door");

        if (otherCollider.tag == "Player")
        {
            SceneManager.LoadScene(levelToLoad);
        }

        
    }

}
