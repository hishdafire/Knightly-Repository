using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    public float movementForce = 25f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // Condition: When the player presses a button...
        if(Input.GetKey(KeyCode.D) == true)
        {
            // Action: Apply a force (move the player)
            Rigidbody2D ourRigidbody = GetComponent<Rigidbody2D>();
            ourRigidbody.AddForce(Vector2.right * movementForce);
        }
        if (Input.GetKey(KeyCode.A) == true)
        {
            Rigidbody2D ourRigidbody = GetComponent<Rigidbody2D>();
            ourRigidbody.AddForce(Vector2.left * movementForce);
        }
        if (Input.GetKey(KeyCode.S) == true)
        {
            Rigidbody2D ourRigidbody = GetComponent<Rigidbody2D>();
            ourRigidbody.AddForce(Vector2.down * movementForce);
        }
        if (Input.GetKey(KeyCode.W) == true)
        {
            Rigidbody2D ourRigidbody = GetComponent<Rigidbody2D>();
            ourRigidbody.AddForce(Vector2.up * movementForce);
        }
    }
}
