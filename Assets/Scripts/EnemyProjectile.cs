// Import necessary libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Define the EnemyProjectile class
public class EnemyProjectile : MonoBehaviour
{
    // Public variable to control the speed of the projectile
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        // Initialization code can be added here if needed
    }

    // Update is called once per frame
    void Update()
    {
        // Move the projectile downwards based on speed and frame time
        transform.Translate(Vector2.down * speed * Time.deltaTime);
    }

    // OnTriggerEnter2D is called when the object's collider enters another collider
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the collided object has the tag "Boundary"
        if (collision.gameObject.tag == "Boundary")
        {
            // Destroy the projectile if it hits the boundary
            Destroy(gameObject);
        }
    }
}
