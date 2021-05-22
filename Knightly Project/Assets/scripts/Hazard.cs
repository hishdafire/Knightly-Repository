using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazard : MonoBehaviour
{

    public int hazardDamage;

    void OnCollisionEnter2D(Collision2D collisionData)
    {
        Collider2D objectWeCollidedWith = collisionData.collider;

        PlayerHealth player = objectWeCollidedWith.GetComponent<PlayerHealth>();

        if (player != null)
        {
            player.HealthChange(-hazardDamage);
        }
    }

}
