using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    // Public Variables
    public float forceStrength;
    public Vector2[] patrolPaths; // the patrol point they will move to
    public float stopDistance; // how close we get before moving towards next point



    // private variables
    private Rigidbody2D ourRigidBody;
    private int currentPoint = 0; //index of current point we are moving towards



    void Awake()
    {
        ourRigidBody = GetComponent<Rigidbody2D>();
    }




    // Update is called once per frame
    void Update()
    {
        // how far are we from target
        float distance = (patrolPaths[currentPoint] - (Vector2)transform.position).magnitude;

        // IF we are closer to our target than our minimum distance...
        if (distance <= stopDistance)
        {
            // ...THEN update to next target
            currentPoint = currentPoint + 1;

            // at the end of the list
            if (currentPoint >= patrolPaths.Length)
            {
                // loop back to start of list
                currentPoint = 0;
            }
        }

        



        // move in the direction of target

        // get direction they should move in
        //Subtracting the current position from the target position
        Vector2 direction = patrolPaths[currentPoint] - (Vector2)transform.position;
        direction = direction.normalized;

        // Move in the correct direction with the set force strength
        ourRigidBody.AddForce(direction * forceStrength);
    }
}
