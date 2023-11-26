// Import necessary libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Define the ShipMovement class
public class ShipMovement : MonoBehaviour
{
    // Public variable to control the movement speed of the ship
    public float moveSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        // Initialization code can be added here if needed
    }

    // Update is called once per frame
    void Update()
    {
        // Move the ship to the right based on the specified speed and frame time
        transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
    }

    // OnTriggerEnter2D is called when the object's collider enters another collider
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the collided object has the tag "Boundary"
        if (collision.gameObject.tag == "Boundary")
        {
            // Adjust the ship's position and change its movement direction
            transform.position = new Vector3(transform.position.x, transform.position.y - 1, transform.position.z);
            moveSpeed *= -1;
        }
    }
}
