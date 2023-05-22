using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLineMovement : MonoBehaviour
{
    // public variables
    public float forceStrength; // how fast the enemy moves


    public Vector2 direction; // what direction the enemy moves

    //Used for tracking data while the game is running
    private Rigidbody2D ourRigidBody;


    // Awake is called when the game starts
    void Awake()
    {
        // Get and store the rigidbody we'll be using
        ourRigidBody = GetComponent<Rigidbody2D>();


        // Normalise our direction
        // normalise changes it to be length 1, so we can multiply
        // it by our speed / force
        direction = direction.normalized;

    }



    // Update is called once per frame
    void Update()
    {
        // Move in the correct direction with the set force strength
        ourRigidBody.AddForce(direction * forceStrength);
    }
}
