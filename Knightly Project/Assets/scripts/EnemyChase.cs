using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChase : MonoBehaviour
{

    public float forceStrength;
    public Transform target;

    private Rigidbody2D ourRigidbody;

    // Start is called before the first frame update
    void Awake()
    {
        ourRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = ((Vector2)target.position - (Vector2)transform.position).normalized;

        ourRigidbody.AddForce(direction * forceStrength);
    }
}
