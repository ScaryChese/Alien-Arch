using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    // Public Variables
    public float forceStrength;
    public Vector2 patrolPath; // the patrol point they will move to


    // private variables
    private Rigidbody2D ourRigidbody;




    void Awake()
    {
        ourRigidbody = GetComponent<Rigidbody2D>();
    }




    // Update is called once per frame
    void Update()
    {
        // move in the direction of target

        // get direction they should move in
        //Subtracting the current position from the target position
        Vector2 direction = (patrolPath - (Vector2)transform.position).normalized;
    }
}
