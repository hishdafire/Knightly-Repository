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
        //get our rigid body that we'll need to find the physics information
        Rigidbody2D ourRigidbody = GetComponent<Rigidbody2D>();

        //find out from the rigid body what our current speeds are
        float currentSpeedH = ourRigidbody.velocity.x;
        float currentSpeedV = ourRigidbody.velocity.y;

        //get the animator component that we will be using for setting our animation
        Animator ourAnimator = GetComponent<Animator>();

        //tell our animator what the speeds are
        ourAnimator.SetFloat("speedH", currentSpeedH);
        ourAnimator.SetFloat("speedV", currentSpeedV);
    

    

        // Condition: When the player presses a button...
        if(Input.GetKey(KeyCode.D) == true)
        {
            // Action: Apply a force (move the player)
            ourRigidbody.AddForce(Vector2.right * movementForce);
        }
        if (Input.GetKey(KeyCode.A) == true)
        {
            ourRigidbody.AddForce(Vector2.left * movementForce);
        }
        if (Input.GetKey(KeyCode.S) == true)
        {
            ourRigidbody.AddForce(Vector2.down * movementForce);
        }
        if (Input.GetKey(KeyCode.W) == true)
        {
            ourRigidbody.AddForce(Vector2.up * movementForce);
        }
    }
}
