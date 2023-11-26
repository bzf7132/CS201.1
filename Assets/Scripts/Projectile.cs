// Import necessary libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Define the Projectile class
public class Projectile : MonoBehaviour
{
    // Public variable to control the movement speed of the projectile
    public float moveSpeed;

    // Reference to the explosion prefab that will be instantiated on collision
    public GameObject explosionPrefab;

    // Reference to the PointManager script for updating the score
    private PointManager pointManager;

    // Start is called before the first frame update
    void Start()
    {
        // Get the PointManager component from the "PointManager" GameObject
        pointManager = GameObject.Find("PointManager").GetComponent<PointManager>();
    }

    // Update is called once per frame
    void Update()
    {
        // Move the projectile upwards based on the specified speed and frame time
        transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);
    }

    // OnTriggerEnter2D is called when the object's collider enters another collider
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the collided object has the tag "Enemy"
        if (collision.gameObject.tag == "Enemy")
        {
            // Instantiate an explosion prefab at the projectile's position
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);

            // Destroy the enemy object
            Destroy(collision.gameObject);

            // Update the score using the PointManager script
            pointManager.UpdateScore(50);

            // Destroy the projectile
            Destroy(gameObject);
        }

        // Check if the collided object has the tag "Boundary"
        if (collision.gameObject.tag == "Boundary")
        {
            // Destroy the projectile when it hits the boundary
            Destroy(gameObject);
        }
    }
}
