using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{

    public GameObject projectilePrefab;
    public Vector2 projectileVelocity;

    public void FireProjectile()
    {
        GameObject clonedProjectile;

        clonedProjectile = Instantiate(projectilePrefab);

        Rigidbody2D projectileRigidbody;

        projectileRigidbody = clonedProjectile.GetComponent<Rigidbody2D>();

        projectileRigidbody.velocity = projectileVelocity;
    }

}
