using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLineMovement : MonoBehaviour
{

    public float forceStrength;

    public Vector2 direction;

    private Rigidbody2D ourRigidbody;

    void Awake()
    {
        ourRigidbody = GetComponent<Rigidbody2D>();

        direction = direction.normalized;
    }

    // Update is called once per frame
    void Update()
    {
        ourRigidbody.AddForce(direction * forceStrength);
    }
}
